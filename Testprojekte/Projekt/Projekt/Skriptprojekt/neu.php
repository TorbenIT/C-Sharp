<?php
	if (isset($_POST['name']) && isset($_POST['email']) && isset($_POST['passwort']))
	{ //legt einen neuen Benutzer in der Datenbank an und verweist auf den Log-Inbereich der Spendenseite
		include("connect.php");
		$insert = "INSERT INTO Spender (Name, Email, Passwort) VALUES ('".$_POST['name']."', '".$_POST['email']."', '".$_POST['passwort']."')";
		mysqli_query($db, $insert);
		mysqli_close($db);
		header("Location: spenden.php");
	}
?>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<link rel="stylesheet" type="text/css" href="css/style.css">
		<meta name="author" content="Tobias Schneider"/>
		<meta name="description" content="Spenden Sie für die Eisbären"/>
		<title>Konto erstellen</title>
	</head>
	<body class="spenden">
		<h1>Neues Konto erstellen</h1>
		<hr>
		<p>Sie möchten spenden? Hier erstellen Sie ein Konto</p>
		<br>
		<br>
		<form method="post">
			<label for="name">Ihre Vor- und Nachname</label>
			<br>
			<input type="text" id="name" name="name"/>
			<br>
			<br>
			<label for="email">Ihre E-Mail</label>
			<br>
			<input type="email" id="email" name="email"/>
			<br>
			<br>
			<label for="passwort">Ihr Passwort</label>
			<br>
			<input type="password" id="passwort" name="passwort"/>
			<br>
			<br>
			<input type="submit" value="Konto Erstellen"/>
		</form>
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