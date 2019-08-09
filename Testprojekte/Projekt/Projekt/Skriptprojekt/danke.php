<?php
	if (isset($_GET['email'])) // wenn die Email gesetzt bzw eingegeben wird, wird folgendes getan: 
	{
		include("connect.php"); // (Includierung der )Datenbankzugriff(sdatei) 
		$select = "SELECT Name FROM Spender WHERE Email = '".$_GET['email']."'"; // Der Name wird von der Tabelle Spender geholt, sowie die Email im Formular der Webseite eingeben wurde 
		// Anfrage an die Datenbank  
		$ergebnis = mysqli_query($db, $select); // Zeiger auf die zugehörige Datenbank (siehe onenote - unterrichtsmaterialien) 
		if ($ergebnis != false) 
		{	// wenn ergebnis nicht fehlerhaft, dann werden die Daten in einem Array abgespeichert 
			$zeile = mysqli_fetch_array($ergebnis);
		}
	}
?>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<link rel="stylesheet" type="text/css" href="css/style.css">
		<meta name="author" content="Tobias Schneider"/>
		<meta name="description" content="Spenden Sie für die Eisbären"/>
		<title>Danke!</title>
	</head>
	<body class="danke">
		<h1>Vielen Dank, <?php echo $zeile['Name']; ?>!</h1> <!-- Bedanken beim Spender mithilfe von php -->
		<hr>
		<p>Wir sagen DANKE!!!</p>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<ul>
			<li>
				<a href="index.html">Startseite</a>
			</li>
			<li>
				<a href="wissenswertes.html">Wissenswertes</a>
			</li>
			<li>
				<a href="spenden.php">Spenden</a>
			</li>
			<li>
				<a href="kontakt.php">Kontakt</a>
			</li>
		</ul>
	</body>
</html>