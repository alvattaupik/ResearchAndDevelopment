<?php 
 
	require_once 'koneksi.php';
	
	$response = array();
	
	if(isset($_GET['apicall'])){
		
		switch($_GET['apicall']){
			
			case 'signup':
				if(isTheseParametersAvailable(array('namalengkap','username','email','passworduser','jeniskelamin'))){
					$namalengkap = $_POST['namalengkap'];
					$username = $_POST['username']; 
					$email = $_POST['email']; 
					$password = $_POST['passworduser'];
					$jeniskelamin = $_POST['jeniskelamin'];
					$status='0';
					// $status = $_POST['status'];					
					
					$stmt = $conn->prepare("SELECT kodeuser FROM usersignup WHERE username = ? OR email = ? ");
					$stmt->bind_param("ss", $username, $email);
					$stmt->execute();
					$stmt->store_result();
					
					if($stmt->num_rows > 0){
						$response['error'] = true;
						$response['message'] = 'Email Sudah Pernah Didaftarkan';
						$stmt->close();
					}else{
						$stmt = $conn->prepare("INSERT INTO usersignup (namalengkap,username, email, passworduser, jeniskelamin,status) VALUES (?, ?, ?, ?, ?, ?)");
						$stmt->bind_param("ssssss",$namalengkap,$username, $email, $password, $jeniskelamin,$status);
 
						if($stmt->execute()){
							$stmt = $conn->prepare("SELECT kodeuser, kodeuser, username, email, jeniskelamin FROM usersignup WHERE username = ?"); 
							$stmt->bind_param("s",$username);
							$stmt->execute();
							$stmt->bind_result($kodeuser, $id, $username, $email, $jeniskelamin);
							$stmt->fetch();
							
							$user = array(
								'id'=>$id, 
								'username'=>$username, 
								'email'=>$email,
								'jeniskelamin'=>$jeniskelamin
							);
							
							$stmt->close();
							
							$response['error'] = false; 
							$response['message'] = 'User registered successfully'; 
							$response['user'] = $user; 
						}
					}
					
				}else{
					$response['error'] = true; 
					$response['message'] = 'required parameters are not available'; 
				}
				
			break; 
			
			case 'login':
				
				if(isTheseParametersAvailable(array('username', 'password'))){
					
					$username = $_POST['username'];
					$password = md5($_POST['password']); 
					
					$stmt = $conn->prepare("SELECT id, username, email, gender FROM users WHERE username = ? AND password = ?");
					$stmt->bind_param("ss",$username, $password);
					
					$stmt->execute();
					
					$stmt->store_result();
					
					if($stmt->num_rows > 0){
						
						$stmt->bind_result($id, $username, $email, $gender);
						$stmt->fetch();
						
						$user = array(
							'id'=>$id, 
							'username'=>$username, 
							'email'=>$email,
							'gender'=>$gender
						);
						
						$response['error'] = false; 
						$response['message'] = 'Login successfull'; 
						$response['user'] = $user; 
					}else{
						$response['error'] = false; 
						$response['message'] = 'Invalid username or password';
					}
				}
			break; 
			
			default: 
				$response['error'] = true; 
				$response['message'] = 'Invalid Operation Called';
		}
		
	}else{
		$response['error'] = true; 
		$response['message'] = 'Invalid API Call';
	}
	
	echo json_encode($response);
	
	function isTheseParametersAvailable($params){
		
		foreach($params as $param){
			if(!isset($_POST[$param])){
				return false; 
			}
		}
		return true; 
	}
?>