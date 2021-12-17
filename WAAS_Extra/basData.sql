-- AnimalType
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (1,"As�tare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (2,"V�xt�tare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (3,"K�tt�tare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (4,"All�tare","1995-11-18 18:34");

-- Habitat
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (1,"Skog","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (2,"Fj�ll","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (3,"Saltvatten","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (4,"S�tvatten","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (5,"Regnskog","1995-11-18 18:34");

-- Animal
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (1,3,1,"Berguv","Bubo bubo","�kta ugglor",20,"Berguven �r den st�rsta ugglearten i Sverige och en skygg j�gare. Berguvarna p� Skansen medverkar i ett projekt f�r att �terintroducera berguv i sk�rg�rden.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (2,4,1,"Brunbj�rn","Ursus arctos","Bj�rnar",30,"Brunbj�rnen k�nns igen p� sitt stora huvud, sm� �gon och �ron samt puckeln �ver frambogen/skulderpartiet. P�lsen �r tjock och f�rgen varierar fr�n ljusbrun till m�rkbrun, �ven brungr� p�ls kan f�rekomma.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (3,3,3,"Gr�s�l","Halichoerus grypus","�ronl�sa s�lar",40,"Gr�s�len �r v�l anpassad f�r ett liv i vatten och kan dyka ner till flera hundra meters djup.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (4,2,5,"Guereza","Colobus guereza","Markattartade apor",30,"Guerezor anses fredliga och en dominerande hane leder flocken. De �r skickliga p� att kl�ttra i tr�d och kan g�ra 10 meter l�nga hopp mellan tr�den.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (5,1,2,"J�rv","Gulo gulo","M�rddjur",12,"J�rven (Gulo gulo) �r v�rldens st�rsta landlevande m�rddjur och den enda arten i sl�ktet Gulo. F�rr i tiden kallades den f�r fj�llfr�s, vilket betyder fj�llkatt. Det fornnordiska namnet lever kvar i tyskans, Vielfrass, som betyder stor�tare.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (6,3,3,"Knubbs�l","Phoca vitulina","�ronl�sa s�lar",30,"Knubbs�len �r i j�mf�relse med andra s�lar liten och slank med ett klotformigt huvud och V-formade n�sborrar.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (7,3,2,"Lappuggla","Strix nebulosa","�kta ugglor",15,"Lappugglan �r en av Sveriges st�rsta ugglor men lappugglans storlek �r delvis en synvilla och beror p� den yviga fj�derdr�kten.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (8,3,1,"Lodjur","Lynx lynx","Kattdjur",10,"Lodjuret �r det enda vilda kattdjuret i Sverige. Det �r ett skyggt rovdjur som s�llan blir uppt�ckt ute i naturen. Lodjur lever i f�rsta hand av r�djur.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (9,4,5,"P�f�gel","Pavo cristatus","Fasanf�glar",15,"P�f�geln k�nns igen av de flesta som bes�kt en djurpark. P� Skansen str�var p�f�glarna fritt �ver omr�det under sommaren.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (10,2,2,"Ren","Rangifer tarandus","Hjortdjur",20,"Tamrenen utg�r en viktig del i den samiska ekonomin och kulturen. De h�rstammar fr�n vildrenen som fortfarande lever i Norge och Sibirien","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (11,3,4,"Utter","Lutra lutra","M�rddjur",6,"Uttern �r ett m�rddjur som varit p� v�g att f�rsvinna i Sverige. Skansen har medverkat i ett projekt f�r att plantera ut uttrar i naturen med mycket gott resultat.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (12,4,1,"Vildsvin","Sus scrofa","Part�iga hovdjur",10,"Vildsvinet var i princip utrotat i Sverige men ett antal djur rymde fr�n ett h�gn i slutet 1900-talet. Nu finns ca 300 000 vildsvin i det fria.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (13,2,1,"Visent","Bison bonasus","Slidhornsdjur",20,"Visenten �r Europas st�rsta d�ggdjur och har st�tt som symbol f�r styrka. En fullvuxen visenttjur backar inte f�r n�gra fiender.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (14,2,1,"�lg","Alces alces","Part�iga hovdjur",10,"Den st�tliga �lgen �r den svenska skogens st�rsta djur och har p� m�nga s�tt blivit ett symboldjur f�r Sverige.","1995-11-18 18:34");

SELECT A.Name, B.Name, C.Name, A.LatinName, A.FamilyName, A.AgeExpectancyYears, A.Description 
FROM Animal AS A INNER JOIN AnimalType AS B ON A.AnimalTypeId = B.AnimalTypeId 
INNER JOIN Habitat AS C ON A.HabitatId = C.HabitatId

UPDATE Animal SET HabitatId = 1 WHERE AnimalId = 7