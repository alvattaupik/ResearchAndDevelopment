<?php
$host = "45.64.1.65";   //Host
$username = "k7839728";    //User
$password = "p15NdHs5y7"; //Passsword
$database = "k7839728_db_test";     // Database Name
 
//creating a new connection object using mysqli 
$conn = new mysqli($host, $username, $password, $database);
 
//if there is some error connecting to the database
//with die we will stop the further execution by displaying a message causing the error.
if ($conn->connect_error) {
    die("Database connection failed: " . $conn->connect_error);
}
?>