<?php
	if (isset($_POST['email']) && isset($_POST['betrag']))
	{
		include("connect.php");
		$select = "SELECT Spender_ID FROM Spender WHERE Email = '".$_POST['email']."'";
		$ergebnis = mysqli_query($db, $select);
		if ($ergebnis != false)
		{
			$zeile = mysqli_fetch_array($ergebnis);
			$insert = "INSERT INTO Spenden (Spender_ID, Betrag) VALUES ('".$zeile['Spender_ID']."', '".$_POST['betrag']."')";
			mysqli_query($db, $insert);
			mysqli_close($db);
			header("Location: danke.php?email=".$_POST['email']);
		}
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
	<body class="spenden">
		<h1>Für Eisbären spenden</h1>
		<hr> 						<!--damit nach der Anmeldung die Seite aktualisiert wird und der Text -->
		<p>Wir freuen uns über eine neue Spende</p>
		<br>
		<br>
		<form method="post">
			<label for="email">Ihr Konto</label>
			<br>
			<input type="email" id="email" name="email" value="<?php echo $_GET['email']; ?>"/>
			<br>
			<br>
			<label for="betrag">Ihr Spendenbetrag</label>
			<br>
			<input type="text" id="betrag" name="betrag" style="width: 70px" placeholder="10,00"/>€
			<br>
			<br>
			<input type="submit" value="Betrag spenden"/>
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