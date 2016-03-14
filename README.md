# Lazerekt - korisnicki generisana potezna strategija za vise igraca u stvarnom vremenu

1. Fedja Tica
2. Igor Vasiljevic
3. Belmin Began (?) - nismo uspjeli stupiti u kontakt
4. Imran Polic (?) - nismo uspjeli stupiti u kontakt

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

### Igranje jedne partije

### Predlaganje novog sadrzaja

Korisnik ulazi u aktivnost za predlaganje novog sadrzaja i tu ima mogucnost da odredi tip sadrzaja koji zeli da doda, da ga definise i da ga predlozi na glasanje.

### Glasanje o novom sadrzaju

Korisnik ulazi u aktivnost za glasanje o novom sadrzaju i ima mogucnost da pogleda predlozene sadrzaje i da glasa da li ga zeli u igri ili ne. Takodjer ima mogucnost da prijavi moderatoru za neprimjeren sadrzaj.

### Banovanje/odbanovanje korisnika

Moderator ili administrator u administratorskoj aplikaciji trazi odredjenog korisnika i ima mogucnost da mu rucno zabrani pristup serverima, i time mu onemoguci igranje s drugim igracima ili da ga odbanuje i time mu vrati sva igraca prava u slucaju da su bila izgubljena.

### Brisanje predlozenog sadrzaja

Moderator ili administrator ima mogucnost da pregleda sve predlozene sadrzaje i one koji su prijavljeni kao neprimjereni. Moderator moze da administratoru proslijedi zahtjev za brisanjem odabranog sadrzaja. Administrator ima mogucnost da odabrani predlozeni sadrzaj izbrise.

### Ukljucivanje predlozenog sadrzaja u igru

U slucaju da tako odluci, administrator moze da odredjeni predlozeni sadrzaj doda u igru.

## Funkcionalnosti

### Proceduralno generisan svijet 

### Korisnicki podaci se cuvaju na cloudu (Azure)

### Povezivanje igraca na osnovu ranga (ELO sistem)

### Dodavanje korisnicki generisanog sadrzaja

## Akteri

1. Korisnik/Igrac - ima mogucnost stvaranja racuna, igranja preko njega sa drugim igracima, mogucnost predlaganja dodatnog sadrzaja za igru
2. Moderator - uloga moderatora je da osigura postenu igru (da provjerava i zabranjuje pristup igracima koji varaju)
3. Administrator - moze da imenuje nove moderatore i da mijenja sadrzaj same aplikacije
