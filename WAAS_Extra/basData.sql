-- AnimalType
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (1,"Asätare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (2,"Växtätare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (3,"Köttätare","1995-11-18 18:34");
INSERT INTO AnimalType (AnimalTypeId,Name,CreatedDate)
VALUES                 (4,"Allätare","1995-11-18 18:34");

-- Habitat
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (1,"Skog","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (2,"Fjäll","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (3,"Saltvatten","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (4,"Sötvatten","1995-11-18 18:34");
INSERT INTO Habitat (HabitatId,Name,CreatedDate)
VALUES              (5,"Regnskog","1995-11-18 18:34");

-- Animal
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (1,3,1,"Berguv","Bubo bubo","Äkta ugglor",20,"Berguven är den största ugglearten i Sverige och en skygg jägare. Berguvarna på Skansen medverkar i ett projekt för att återintroducera berguv i skärgården.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (2,4,1,"Brunbjörn","Ursus arctos","Björnar",30,"Brunbjörnen känns igen på sitt stora huvud, små ögon och öron samt puckeln över frambogen/skulderpartiet. Pälsen är tjock och färgen varierar från ljusbrun till mörkbrun, även brungrå päls kan förekomma.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (3,3,3,"Gråsäl","Halichoerus grypus","Öronlösa sälar",40,"Gråsälen är väl anpassad för ett liv i vatten och kan dyka ner till flera hundra meters djup.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (4,2,5,"Guereza","Colobus guereza","Markattartade apor",30,"Guerezor anses fredliga och en dominerande hane leder flocken. De är skickliga på att klättra i träd och kan göra 10 meter långa hopp mellan träden.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (5,1,2,"Järv","Gulo gulo","Mårddjur",12,"Järven (Gulo gulo) är världens största landlevande mårddjur och den enda arten i släktet Gulo. Förr i tiden kallades den för fjällfräs, vilket betyder fjällkatt. Det fornnordiska namnet lever kvar i tyskans, Vielfrass, som betyder storätare.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (6,3,3,"Knubbsäl","Phoca vitulina","Öronlösa sälar",30,"Knubbsälen är i jämförelse med andra sälar liten och slank med ett klotformigt huvud och V-formade näsborrar.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (7,3,2,"Lappuggla","Strix nebulosa","Äkta ugglor",15,"Lappugglan är en av Sveriges största ugglor men lappugglans storlek är delvis en synvilla och beror på den yviga fjäderdräkten.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (8,3,1,"Lodjur","Lynx lynx","Kattdjur",10,"Lodjuret är det enda vilda kattdjuret i Sverige. Det är ett skyggt rovdjur som sällan blir upptäckt ute i naturen. Lodjur lever i första hand av rådjur.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (9,4,5,"Påfågel","Pavo cristatus","Fasanfåglar",15,"Påfågeln känns igen av de flesta som besökt en djurpark. På Skansen strövar påfåglarna fritt över området under sommaren.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (10,2,2,"Ren","Rangifer tarandus","Hjortdjur",20,"Tamrenen utgör en viktig del i den samiska ekonomin och kulturen. De härstammar från vildrenen som fortfarande lever i Norge och Sibirien","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (11,3,4,"Utter","Lutra lutra","Mårddjur",6,"Uttern är ett mårddjur som varit på väg att försvinna i Sverige. Skansen har medverkat i ett projekt för att plantera ut uttrar i naturen med mycket gott resultat.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (12,4,1,"Vildsvin","Sus scrofa","Partåiga hovdjur",10,"Vildsvinet var i princip utrotat i Sverige men ett antal djur rymde från ett hägn i slutet 1900-talet. Nu finns ca 300 000 vildsvin i det fria.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (13,2,1,"Visent","Bison bonasus","Slidhornsdjur",20,"Visenten är Europas största däggdjur och har stått som symbol för styrka. En fullvuxen visenttjur backar inte för några fiender.","1995-11-18 18:34");
INSERT INTO Animal (AnimalId,AnimalTypeId,HabitatId,Name,LatinName,FamilyName,AgeExpectancyYears,Description,CreatedDate)
VALUES             (14,2,1,"Älg","Alces alces","Partåiga hovdjur",10,"Den ståtliga älgen är den svenska skogens största djur och har på många sätt blivit ett symboldjur för Sverige.","1995-11-18 18:34");

SELECT A.Name, B.Name, C.Name, A.LatinName, A.FamilyName, A.AgeExpectancyYears, A.Description 
FROM Animal AS A INNER JOIN AnimalType AS B ON A.AnimalTypeId = B.AnimalTypeId 
INNER JOIN Habitat AS C ON A.HabitatId = C.HabitatId

UPDATE Animal SET HabitatId = 1 WHERE AnimalId = 7