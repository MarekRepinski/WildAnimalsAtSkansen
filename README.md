# WildAnimalsAtSkansen

This repo is a part of a schoolwork and the rest of this information is written in Swedish.  
(If anyone non-Swedish speaking happened to stumbled in)

BE Labb 1 och BE Labb 2 (förhoppningsvis)  
Listar de "vilda" djuren på Skansen enligt deras [websida](https://www.skansen.se/sv/vilda-djur-pa-skansen).

## Beskrivning
En enkel Web-API som hanterar en CRUD, kopplad till en MySQL-databas.  
Den byggd enligt MVC (Model - View - Controll).

## Databas model
Tre tabeller:  
- Animal
- AnimalType
- Habitat

AnimalType har en `En till Många` relation till Animal.  
Även Habitat har en `En till Många` relation till Animal.

Screenshot finns i WAAS_Extra.  
Seedning till databasen görs via INSERT INTO-satser. Dessa finns i filen basData.sql i WAAS_Extra.

## Anrop
- **GET /api/WAAS/Animals**  
Ger en lista med alla djur i databasen. FK AnimalType och FK Habitat byts ut mot AnimalType.Name respektive Habitat.Name. Detta sker med hjälp av en IQueryable. Statiska medtoderna för detta finns i AnimalDTO.cs.
- **GET /api/WAAS/Animal/1**  
Ger info för djur med AnimalId ==1 i databasen. FK AnimalType och FK Habitat byts ut mot AnimalType.Name respektive Habitat.Name. Detta sker med hjälp av en IQueryable. Statiska medtoderna för detta finns i AnimalDTO.cs.
- **GET /api/WAAS/Animal/Vi**  
Ger en lista med alla djur som har namn som börjar på `Vi` i databasen. FK AnimalType och FK Habitat byts ut mot AnimalType.Name respektive Habitat.Name. Detta sker med hjälp av en IQueryable. Statiska medtoderna för detta finns i AnimalDTO.cs.
- **GET /api/WAAS/AnimalType/1**  
Ger en lista med alla djur av typen AnimalTypeId == 1. FK AnimalType och FK Habitat byts ut mot AnimalType.Name respektive Habitat.Name. Detta sker med hjälp av ef.
- **GET /api/WAAS/Habitat/1**  
Ger en lista med alla djur av typen HabitatId == 1. FK AnimalType och FK Habitat byts ut mot AnimalType.Name respektive Habitat.Name. Detta sker med hjälp av ef.
- **POST /api/WAAS/**  
Lägger till en ny post i Animal. AnimalTypeId och HabitatId måste anges.
- **PUT /api/WAAS/**  
Uppdaterar en post i Animal. AnimalTypeId och HabitatId måste anges.
- **DEL /api/WAAS/1**  
Tar bort posten med AnimalId == 1 ur databasen. 

## Labb 2
Så vitt jag förstår så borde detta täcka alla kriterier för även Labb 2. Det skulle vara om du vill ha flera nivåer på slagningen med alla djur.
Ur FE-synpunkt så vill man ha så platt struktur som möjligt på svaren man får för det är lättare att bearbeta. Om du håller en kniv mot min strupe så
kan jag bygga en GetRubbet...  
Sedan vet jag inte om du är nöjd med SQL-seedningen. Jag kan lyfta in den i ApplicationContext om du tjatar...:roll_eyes:
