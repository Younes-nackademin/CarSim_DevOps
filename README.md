# Car Simulator DevOps Project

## Projektbeskrivning
Detta projekt är en del av kursen DevOps och syftar till att implementera en CI/CD-pipeline med Azure DevOps för en ASP.NET Core-applikation.  
Applikationen, Car Simulator, simulerar rörelser och riktningar för en bil genom olika strategiklasser och logik.  

Projektet innehåller:
- En backend i C#/.NET  
- En pipeline i Azure DevOps med tre stages (Build, Test, Deploy)  
- En publicerad webbapp på Azure

---

## Funktioner
- Bygger hela lösningen automatiskt via Azure Pipelines  
- Kör alla enhetstester (26 st) med 100 % pass-rate  
- Rensar alla warnings innan build  
- Deployar automatiskt till Azure App Service  
- Webbsidan har en index.html som standardfil för att visa att deployment lyckats  

---

## CI/CD Pipeline
Pipelinefilen heter azure-pipelines.yml och innehåller följande stages:

### Build Stage
- Installerar .NET SDK  
- Installerar NuGet  
- Bygger hela lösningen  

### Test Stage
- Kör alla enhetstester via DotNetCoreCLI@2  
- Genererar testresultat och kodtäckning  

### Deploy Stage
- Publicerar till Azure App Service  
- Appen hostas på:  
  https://carsimulatorapp123younes.azurewebsites.net

---

## Tester
- Antal tester: 26 st  
- Resultat: 100 % passed  
- Testerna säkerställer logiken i:
  - DirectionContext  
  - DriveForwardStrategy  
  - TurnLeftStrategy  
  - TurnRightStrategy  
  - ReverseStrategy  
  - SimulationLogicService  

Pipeline-logg visar:  
26 Total tests — 100% Passed — 0 Failed — 0 Warnings

---

## Teknisk miljö
- Visual Studio 2022  
- .NET SDK 9.0.x  
- Azure DevOps  
- Azure App Service  
- GitHub version control

---

## Azure Deployment
Appen är publicerad till:  
https://carsimulatorapp123younes.azurewebsites.net  

Vid lyckad publicering visas:  
"Application deployed successfully"

---

## Sammanfattning av inlämningen
| Krav | Status | Kommentar |
|------|--------|------------|
| 20–40 enhetstester | 26 st, alla godkända |
| Inga warnings/errors | 0 Errors, 0 Warnings |
| Pipelines i tre stages | Build, Test, Deploy |
| Deployment till Azure | Lyckad publicering |
| README.md | Inkluderad |

---

## Skapad av
Younes Kesraoui  
Nackademin YH — Webbutveckling .NET
