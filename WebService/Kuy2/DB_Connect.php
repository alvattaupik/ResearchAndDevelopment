<?php
$serverName = "10.1.0.53";
$connectionOptions = array(
    "Database" => "DB_EMAIL",
    "Uid" => "sa",
    "PWD" => "h0spit4lity#"
);
//Establishes the connection
$conn = sqlsrv_connect($serverName, $connectionOptions);

?>