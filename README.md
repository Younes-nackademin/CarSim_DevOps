# Car Simulator DevOps Project

## Projektbeskrivning
Detta projekt är en del av kursen **DevOps** och visar hur man implementerar en **CI/CD-pipeline** i **Azure DevOps** för en **ASP.NET Core-applikation**.  
Applikationen **Car Simulator** simulerar bilens rörelser och riktningar genom olika strategiklasser och logik.

---

## Funktioner
- Automatisk build, test och deployment via Azure Pipelines  
- Alla 26 enhetstester körs automatiskt och har **100 % godkänt resultat**  
- Inga warnings eller errors i hela lösningen  
- Applikationen publiceras automatiskt till **Azure App Service**  

---

## Pipeline
Pipeline-filen heter **azure-pipelines.yml** och består av tre steg:
1. **Build** – installerar .NET SDK, återställer paket och bygger projektet  
2. **Test** – kör alla 26 enhetstester och rapporterar resultat till Azure  
3. **Deploy** – publicerar applikationen till Azure App Service  

Applikationen finns publicerad på:  
**https://carsimulatorapp123younes-h4eyd2htf7awa4ac.swedencentral-01.azurewebsites.net/**  

---

## Tester
- Antal unika tester: **26 st**  
- Resultat: **26 passerade av 26 totalt (100 %)**  
- Testerna verifierar logiken i:
  - **DirectionContext**  
  - **DriveForwardStrategy**  
  - **TurnLeftStrategy**  
  - **TurnRightStrategy**  
  - **ReverseStrategy**  
  - **SimulationLogicService**  

Pipeline-loggen visar:  
**26 Total tests — 26 Passed — 0 Failed — 0 Warnings**

---

## Teknisk miljö
- **Visual Studio 2022**  
- **.NET SDK 9.0.x**  
- **Azure DevOps**  
- **Azure App Service**  
- **GitHub** för versionshantering  

---

## Sammanfattning
| Krav | Status |
|------|--------|
| 20–40 enhetstester | ✅ 26 st, alla godkända |
| Inga warnings/errors | ✅ 0 Errors, 0 Warnings |
| Pipeline i tre steg | ✅ Build, Test, Deploy |
| Deployment till Azure | ✅ Lyckad publicering |
| README.md | ✅ Inkluderad och uppdaterad |
