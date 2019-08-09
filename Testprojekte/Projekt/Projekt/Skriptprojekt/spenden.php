<?php
	if (isset($_POST['email']) && isset($_POST['passwort']))
	{ 	//wenn einlogdaten stimmen, wird auf ein Spendenformular verwiesen, um zu spenden!
		include("connect.php");
		$select = "SELECT Passwort FROM Spender WHERE Email = '".$_POST['email']."'";
		$ergebnis = mysqli_query($db, $select);
		if ($ergebnis != false)
		{
			$zeile = mysqli_fetch_array($ergebnis);
			if ($zeile['Passwort'] == $_POST['passwort'])
			{
				header("Location: neuespende.php?email=".$_POST['email']);
			}
		}
		mysqli_close($db);
	}
?>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<link rel="stylesheet" type="text/css" href="css/style.css">
		<meta name="author" content="Tobias Schneider"/>
		<meta name="description" content="Spenden Sie für die Eisbären"/>
		<title>Spenden</title>
	</head>
	<body class="spenden"> <!-- Hintergrundbild setzen von Seite Spenden  -->
		<h1>Für Eisbären spenden</h1>
		<hr>
		<p>Bitte melden Sie sich an, um fortzufahren</p>
		<br>
		<br>
		<form method="post">
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
			<input type="submit" value="Anmelden"/>
			<br>
			<br>
			<a href="neu.php">Noch kein Spender?</a>
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