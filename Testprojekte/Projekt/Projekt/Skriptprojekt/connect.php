<?php
	$db = mysqli_connect("localhost", "root", ""); 
	if ($db == false)
	{
		die("Verbindung fehlgeschlagen");
	}
	else					//Datenbankzugriffsdatei (siehe Onenote.PHP.Datenbankzugriff) 
	{
		mysqli_set_charset($db, "utf8");
		mysqli_select_db($db, "SchneiderTobias");
	}
?>