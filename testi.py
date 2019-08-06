import random
laskuri = 0
voitot = 0
haviot = 0
tasapelit = 0
vaihtoehdot = ['Jalka', 'Ydinase', 'Torakka']

while True:
	valinta = input('Jalka, Ydinase vai Torakka? (Lopeta lopettaa): ')
	if valinta == 'Lopeta':
		print('Pelasit ' + str(laskuri) + ' kierrosta, joista voitit ' + str(voitot) + ' ja pelasit tasan ' + str(tasapelit) + ' peliä.')
		exit()
	print('Sinä valitsit: ' + valinta)
	valitsin = random.randint(0,2)
	cpu = vaihtoehdot[valitsin]
	print('tietokone valitsi: ' + cpu)

	if valinta == cpu:
		print('Tasapeli!')
		tasapelit+=1
	elif valinta == 'Jalka':
		if cpu == 'Ydinase':
			print('Hävisit!')
			haviot+=1
		else:
			print('Voitit!')
			voitot+=1
	elif valinta == 'Ydinase':
		if cpu == 'Torakka':
			print('Hävisit!')
			haviot+=1
		else:
			print('Voitit!')
			voitot+=1
	elif valinta == 'Torakka':
		if cpu == 'Jalka':
			print('Hävisit!')
			haviot+=1
		else: 
			print('Voiti!')
			voitot+=1
	
	laskuri+=1

