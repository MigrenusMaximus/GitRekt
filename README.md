![Lazerekt](lazerekt_logo.png)

# Korisnicki generisana potezna strategija za vise igraca u stvarnom vremenu

1. Fedja Tica
2. Igor Vasiljevic
3. Imran Polic
4. Belmin Began (?) - nismo uspjeli stupiti u kontakt

## Opis teme

Lazerekt je potezna strategija za vise igraca u stvarnom vremenu smjestena u svemiru sa dinamickim sadrzajem kojim upravaljaju korisnici.
Korisnici imaju mogucnost da predlazu i glasaju o odredjenim sadrzajima koji se mogu dodati u igru, time stvarajuci potencijalno beskonacno prosirivo korisnicko iskustvo.

## Procesi

### Prijava

Pri ukljucivanju aplikacije korisnik ima opciju da se prijavi ili registruje, u slucaju da nema racun.
Nakon uspjesne registracije, korisnicki login podaci se spasavaju na cloud i od tada se korisnik moze prijaviti.
Nakon prijave, korisnik dolazi u glavni meni.

### Povezivanje s drugim igracima

Pri zapocinjanju pretrage za protivnikom server trazi drugog korisnika koji trenutno takodjer zapocinje pretragu.
Pokusavaju se upariti korisnici sa sto manjom razlikom u rangu, ali se kriterij siri i prema gore i prema dole sto duze nije moguce naci odgovarajuceg protivnika.

### Igranje jedne kampanje

Po zapocinjanju kampanje, igrac se smjesta u nasumican proceduralno generisan svijet i napreduje po cvorovima do konacnog cvora. Po gubitku partije ili pobjedi u konacnom cvoru, kampanja se zavrsava i korisnik dobija nagrade na osnovu njegovog uspjeha u kampanji. Svaki cvor ukljucuje sukob sa drugim korisnikom i pobjeda u sukobu je uslov za nastavak.

### Predlaganje novog sadrzaja

Korisnik ulazi u aktivnost za predlaganje novog sadrzaja i tu ima mogucnost da odredi tip sadrzaja koji zeli da doda, da ga definise i da ga predlozi na glasanje.

### Glasanje o novom sadrzaju

Korisnik ulazi u aktivnost za glasanje o novom sadrzaju i ima mogucnost da pogleda predlozene sadrzaje i da glasa da li ga zeli u igri ili ne. Takodjer ima mogucnost da prijavi moderatoru za neprimjeren sadrzaj.

### Zabrana/davanje pristupa sistemu korisniku

Moderator ili administrator u administratorskom meniju trazi odredjenog korisnika i ima mogucnost da mu rucno zabrani pristup serverima, i time mu onemoguci igranje s drugim igracima ili da ga odbanuje i time mu vrati sva igraca prava u slucaju da su bila izgubljena.

### Brisanje predlozenog sadrzaja

Moderator ili administrator ima mogucnost da pregleda sve predlozene sadrzaje i one koji su prijavljeni kao neprimjereni. Moderator moze da administratoru proslijedi zahtjev za brisanjem odabranog sadrzaja. Administrator ima mogucnost da odabrani predlozeni sadrzaj izbrise.

### Ukljucivanje predlozenog sadrzaja u igru

U slucaju da tako odluci, administrator moze da odredjeni predlozeni sadrzaj doda u igru.

## Funkcionalnosti

### Dodavanje korisnicki generisanog sadrzaja

Korisnici imaju mogucnost da predlazu novi sadrzaj i glasaju za to koji sadrzaj zele da se implementira u igru i time oni odredjuju u kojem ce se smjeru igra razvijati.

### Proceduralno generisan svijet

Na pocetku svake kampanje se stvara novi svijet koristeci ukljucene sadrzaje, kao i sadrzaje koje su dodali drugi korisnici. Time se osigurava da svaka kampanja bude jednistvena.

### Korisnicki podaci se cuvaju na cloudu (Azure)

Svi korisnicki podaci su sigurni i cuvaju se na cloudu. Pored toga, server sluzi za validaciju unosa i poteza da bi se sprijecilo varanje.

### Povezivanje igraca na osnovu ranga (Elo sistem)

Koristi se Elo sistem, provjeren sistem rangiranja takmicara na osnovu sposobnosti koji se poceo koristi za rangiranje sahista i danas ima nezamjenjivu ulogu kao objektivna mjera sposobnosti u "1-na-1" takmicenjima.

## Akteri

1. Korisnik/Igrac - ima mogucnost stvaranja racuna, igranja preko njega sa drugim igracima, mogucnost predlaganja dodatnog sadrzaja za igru
2. Moderator - uloga moderatora je da osigura postenu igru (da provjerava i zabranjuje pristup igracima koji varaju)
3. Administrator - moze da imenuje nove moderatore i da mijenja sadrzaj same aplikacije
