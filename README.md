# Car Simulator DevOps Project

## Projektbeskrivning
Detta projekt är en del av kursen **DevOps** och syftar till att skapa en fungerande **CI/CD-pipeline** i **Azure DevOps** för en **ASP.NET Core-applikation**.  
Applikationen, **Car Simulator**, simulerar en bils rörelser och riktningar med hjälp av strategiklasser och logik i backend-delen.  

Projektet består av:  
- En backend byggd i **C#/.NET**  
- En pipeline i **Azure DevOps** med tre steg: *Build*, *Test* och *Deploy*  
- En publicerad webbapplikation på **Azure App Service**

---

## Funktioner
- Automatisk build via Azure Pipelines  
- Körning av enhetstester med **100 % godkända resultat**  
- Rensning av alla warnings före build  
- Automatisk publicering till Azure App Service  
- En `index.html`-fil som visar att deployment lyckades  

---

## CI/CD-pipeline
Pipelinefilen **azure-pipelines.yml** innehåller följande steg:

### Build Stage
- Installerar .NET SDK  
- Installerar NuGet  
- Bygger hela lösningen  

### Test Stage
- Kör enhetstester via DotNetCoreCLI@2  
- Genererar testresultat och kodtäckning  

### Deploy Stage
- Publicerar till Azure App Service  
- Webappen finns på:  
  **https://carsimulatorapp123younes-h4eyd2htf7awa4ac.swedencentral-01.azurewebsites.net/**  

---

## Tester
- Antal tester: **26 st**  
- Alla tester passerade: **100 %**  
- Testerna verifierar funktionaliteten i:
  - **DirectionContext**  
  - **DriveForwardStrategy**  
  - **TurnLeftStrategy**  
  - **TurnRightStrategy**  
  - **ReverseStrategy**  
  - **SimulationLogicService**

Pipeline-loggen visar:  
**26 tests — 26 Passed — 0 Failed — 0 Warnings**

---

## Teknisk miljö
- **Visual Studio 2022**  
- **.NET SDK 9.0.x**  
- **Azure DevOps**  
- **Azure App Service**  
- **GitHub Version Control**

---

## Azure-deployment
Webbapplikationen är publicerad och tillgänglig på:  
**https://carsimulatorapp123younes-h4eyd2htf7awa4ac.swedencentral-01.azurewebsites.net/**  


---

## Projektstatus
| Delmoment | Resultat | Kommentar |
|------------|-----------|------------|
| Enhetstester (20–40 st) | 26 genomförda och godkända |
| Warnings/Errors | Inga kvar |
| CI/CD-pipeline | Tre separata steg: Build, Test, Deploy |
| Deployment till Azure | Fungerar och publicerar korrekt |
| Dokumentation | README.md|

---


