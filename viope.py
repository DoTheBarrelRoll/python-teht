# -*- coding: UTF-8 -*-
import pickle
import time

muistio = 'muistio.dat'
def main():
    try:
        open('muistio.dat')
    except IOError:
        print('Virhe tiedostossa, luodaan uusi muistio.dat')
        tiedosto = open(muistio, 'br')
        merkinnat = pickle.load(tiedosto)
        tiedosto.close()
    else:
        tiedosto = open(muistio, 'br')
        try:
            merkinnat = pickle.load(tiedosto)
            tiedosto.close()
        except EOFError:
            merkinnat = []
            tiedosto.close()

    while True:
        valinta = input('(1) Lue muistikirjaa\n(2) Lisää merkintä\n(3) Muokkaa merkintää\n(4) Poista merkintä\n(5) Tallenna ja lopeta\n')
        
        if valinta == "1":
            for kirjaus in merkinnat:
                print(kirjaus)

        elif valinta == "2":
            tiedosto = open(muistio, 'bw')
            inputti = input("Mitä haluaisit lisätä?: ")
            merkinta = str(inputti) + ':::' + time.strftime("%X %x")
            merkinnat.append(merkinta)
            pickle.dump(merkinnat, tiedosto)
            tiedosto.close()
            
        elif valinta == '3':
            tiedosto = open(muistio, 'bw')
            print('Listalla on ' + str(len(merkinnat)) + ' merkintää.\nMitä niistä muutetaan?')
            valinta = int(input()) - 1
            print(merkinnat[valinta])
            print('Anna uusi teksti: ')
            inputti = input()
            merkinta = str(inputti) + ':::' + time.strftime("%X %x")
            merkinnat.insert(valinta, merkinta)
            del merkinnat[valinta + 1]
            pickle.dump(merkinnat, tiedosto)
            tiedosto.close()

        elif valinta == '4':
            tiedosto = open(muistio, 'bw')
            print('Listalla on ' + str(len(merkinnat)) + ' merkintää.\nMikä niistä poistetaan?')
            valinta = int(input()) - 1
            print('Poistettiin merkintä ' + merkinnat[valinta])
            del merkinnat[valinta]
            pickle.dump(merkinnat, tiedosto)
            tiedosto.close()

        elif valinta == '5':
            print('Lopetetaan.')
            tiedosto = open(muistio, 'bw')
            pickle.dump(merkinnat, tiedosto)
            tiedosto.close()
            exit(0)

if __name__ == "__main__":
    main()