<?php
	if (isset($_POST['email']) && isset($_POST['nachricht']))
	{ 			//Wenn Email und NAchricht gesetzt sind, wird  in der Tabelle Kontakt die Email mit der Nachricht angelegt und in der Tabelle Values die Nachricht angelegt! 
		include("connect.php");
		$insert = "INSERT INTO Kontakt (Email, Nachricht) VALUES ('".$_POST['email']."', '".$_POST['nachricht']."')";
		mysqli_query($db, $insert);
		mysqli_close($db);
		header("Location: index.html");
	}
?>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<link rel="stylesheet" type="text/css" href="css/style.css">
		<meta name="author" content="Tobias Schneider"/>
		<meta name="description" content="Spenden Sie für die Eisbären"/>
		<title>Kontakt</title>
	</head>
	<body class="startseite"> <!-- setzen des Hintergrundbildes auf der Kontaktseite  -->
		<h1>Kontaktformular</h1>
		<hr>
		<p>Fragen? Ich stehe Ihnen gerne zur Verfügung</p>
		<br>
		<br>
		<form method="post"> <!-- Art der Datenübertragung; post=Variablen nicht sichtbar  -->
			<label for="email">Ihre E-Mail</label>
			<br>
			<input type="email" id="email" name="email"/>
			<br>
			<br>
			<label for="nachricht">Ihre Nachricht</label>
			<br>
			<textarea id="nachricht" name="nachricht" rows="5"></textarea>
			<br>
			<br>
			<input type="submit" value="Abschicken"/>
		</form> <!-- Formular für die Kontaktaufnahme mit mir  -->
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
				<a href="kontakt.html">Kontakt</a>
			</li>
		</ul>
	</body>
</html>