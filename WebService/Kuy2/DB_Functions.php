<?php

class DB_Functions
{

    // constructor
    function __construct()
    {

    }


    function __destruct(){
    }



    public function simpanUser($nama, $email, $password)
    {

        $serverName = "10.1.0.53";
        $connectionOptions = array(
            "Database" => "DB_EMAIL",
            "Uid" => "sa",
            "PWD" => "h0spit4lity#");
        $conn = sqlsrv_connect($serverName, $connectionOptions);
        // $uuid = uniqid('', true);
        // $hash = $this->hashSSHA($password);
        // $encrypted_password = $hash["encrypted"]; // encrypted password
        // $salt = $hash["salt"]; // salt
		

        $tsql = "INSERT INTO UserLogin(KodePegawai, NamaPegawai, UserNameLogin, PasswordLogin, KodeAplikasi,KodeLevelUser,StatusEnabled) VALUES(?, ?, ?, ?, ?, ?, ?);";
        // $params = array($uuid, $nama, $email, $encrypted_password,"000","007","0");
		 $params = array("1231321","Alvat","Al007","1215142","000","a","1");
        $getResults = sqlsrv_query($conn, $tsql, $params);
        $rowsAffected = sqlsrv_rows_affected($getResults);
		
		if ($getResults == FALSE or $rowsAffected == FALSE)
					die(FormatErrors(sqlsrv_errors()));
					echo ($rowsAffected. " row(s) inserted: " . PHP_EOL);
					sqlsrv_free_stmt($getResults);
		
		
		
		
		
		// $rows_affected = sqlsrv_rows_affected( $getResults);
		// if( $rows_affected === false) {
			// die( print_r( sqlsrv_errors(), true));
				// } elseif( $rows_affected == -1) {
					// echo "No information available.<br />";
					// } else {
						// echo $rows_affected." rows were inserted.<br />";
				// }
		
		
		
		
	/* 	if ($getResults == FALSE or $rowsAffected == FALSE)
			// die(FormatErrors(sqlsrv_errors()));
			sqlsrv_free_stmt($getResults); */
		
		
		
			$tsql= "SELECT * From UserLogin Where UserNameLogin = 'Al007' ;";
			$params = array("Al007");
			$getResults= sqlsrv_query($conn, $tsql);
			echo ("Reading data from table" . PHP_EOL);
			
			if ($getResults == FALSE)
				die(FormatErrors(sqlsrv_errors()));
				while ($row = sqlsrv_fetch_array($getResults, SQLSRV_FETCH_ASSOC)) {
					$user= ($row['KodePegawai'] . " " . $row['NamaPegawai'] . " " . $row['UserNameLogin'] . PHP_EOL);
					echo $user;
				}
				sqlsrv_free_stmt($getResults);
				function FormatErrors( $errors )
				{
					
			/* Display errors. */
			echo "Error information: ";
			foreach ( $errors as $error )
			{
				echo "SQLSTATE: ".$error['SQLSTATE']."";
				echo "Code: ".$error['code']."";
				echo "Message: ".$error['message']."";
			}
			
			
			
		

		}
	}
}

?>