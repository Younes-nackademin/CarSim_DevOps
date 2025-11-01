# Car Simulator DevOps Project

## Projektbeskrivning
Detta projekt är en del av kursen **DevOps** och syftar till att implementera en **CI/CD-pipeline** med Azure DevOps för en **ASP.NET Core-applikation**.  
Applikationen, **Car Simulator**, simulerar rörelser och riktningar för en bil genom olika strategiklasser och logik.  

Projektet innehåller:
- En backend i **C#/.NET**  
- En pipeline i **Azure DevOps** med tre stages (Build, Test, Deploy)  
- En publicerad webbapp på **Azure App Service**

---

## Funktioner
- Bygger hela lösningen automatiskt via Azure Pipelines  
- Kör alla enhetstester med **100 % pass-rate**  
- Rensar alla warnings innan build  
- Deployar automatiskt till Azure App Service  
- Webbsidan har en `index.html` som standardfil för att visa att deployment lyckats  

---

## CI/CD Pipeline
Pipelinefilen heter **azure-pipelines.yml** och innehåller följande stages:

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
  **https://carsimulatorapp123younes-h4eyd2htf7awa4ac.swedencentral-01.azurewebsites.net**

---

## Tester
- Unika tester i projektet: **ca 25–30 st**  
- Totalt körda testresultat i pipeline: **345**  
- Pass rate: **100 %**  
- Testerna säkerställer logiken i:
  - DirectionContext  
  - DriveForwardStrategy  
  - TurnLeftStrategy  
  - TurnRightStrategy  
  - ReverseStrategy  
  - SimulationLogicService  

Pipeline-logg visar:  
**345 Total test results — 100% Passed — 0 Failed — 0 Warnings**

---

## Teknisk miljö
- **Visual Studio 2022**  
- **.NET SDK 9.0.x**  
- **Azure DevOps**  
- **Azure App Service**  
- **GitHub version control**

---

## Azure Deployment
Applikationen är publicerad och tillgänglig på:  
**https://carsimulatorapp123younes-h4eyd2htf7awa4ac.swedencentral-01.azurewebsites.net**  

Vid lyckad publicering visas:  
**"Application deployed successfully"**

---

## Sammanfattning av inlämningen
| Krav | Status | Kommentar |
|------|--------|------------|
| 20–40 unika enhetstester | Uppfyllt — 25–30 unika, 345 körda i pipeline |
| Inga warnings/errors | 0 Errors, 0 Warnings |
| Pipelines i tre stages | Build, Test, Deploy — alla lyckade |
| Deployment till Azure | Lyckad publicering till App Service |
| README.md | Inkluderad och uppdaterad |

---

## Skapad av
**Younes Kesraoui**  
Nackademin, 2025
