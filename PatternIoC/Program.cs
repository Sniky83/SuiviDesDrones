using PatternIoC;

Bus bus = new ();
Velo velo = new ();
VoitureElectrique voitureElectrique = new ();

Person person = new("Igor", voitureElectrique);
person.AllerAuTravail(new Destination("14 rue de saint michel"));