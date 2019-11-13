<?php 
 
	require_once 'koneksi.php';
	
	$response = array();
	
	if(isset($_GET['apicall'])){
		
		switch($_GET['apicall']){
			
			case 'signup':
				if(isTheseParametersAvailable(array('namalengkap','jeniskelamin','alamatemail','nohp','usernamelogin','passwordlogin','statusregister'))){

					$namalengkap = $_POST['namalengkap'];
					$jeniskelamin = $_POST['jeniskelamin'];
					$alamatemail = $_POST['alamatemail'];
					$nohp = $_POST['nohp'];
					$usernamelogin = $_POST['usernamelogin'];
					$passwordlogin = $_POST['passwordlogin'];
					$statusregister = $_POST['statusregister'];
					
					
					$stmt = $conn->prepare("SELECT alamatemail FROM UserSignUp WHERE alamatemail = ?");
					$stmt->bind_param("s",$alamatemail);
					$stmt->execute();
					$stmt->store_result();
					
					if($stmt->num_rows > 0){
						$response['error'] = true;
						$response['message'] = 'User already registered';
						$stmt->close();
					}else{
						$stmt = $conn->prepare("INSERT INTO UserSignUp ('Namalengkap','Jeniskelamin','alamatemail','nohp','usernamelogin','passwordlogin','statusregister') VALUES (?, ?, ?, ?, ?, ?, ?)");
						$stmt->bind_param("sssssss", $namalengkap, $jeniskelamin, $alamatemail, $nohp,$usernamelogin,$passwordlogin,$statusregister);

 
 
						if($stmt->execute()){
							$stmt = $conn->prepare("SELECT namalengkap,alamatemail FROM UserSignUp WHERE alamatemail = ?"); 
							$stmt->bind_param("s",$alamatemail);
							$stmt->execute();
							$stmt->bind_result($namalengkap,$alamatemail);
							$stmt->fetch();
							
							$user = array(
								
								'Prmnamalengkap'=>$namalengkap, 
								'Prmalamatemail'=>$alamatemail,
	
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
					
					$stmt = $conn->prepare("SELECT id, username, email, gender FROM users WHERE username = ? AND passworduser = ?");
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