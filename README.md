# En-komplett-webbapplikation
Dynamiska Webbsystem 2 - januari 2021
## Inlämningsuppgift i Klientgränsnitt och Webb API:er
100/100 (G)
### Scenario och uppgiftsbeskrivning
Du har under Hackathonet fått följande uppgift:

> Hej! Vi är en naturhistorisk förening med fokus på rymden, som skulle vilja göra allt fantastiskt som hänt på Mars de senaste åren mer tillgängligt för unga människor i Sverige. NASA har ett antal rymddrönare på planeten som tagit, och som fortfarande tar foton på planetens yta! Vi har en en liten budget men skulle vilja göra någon slags applikation där man kan läsa på om dessa drönare och se bilder därifrån.
Vi skulle vilja att appen är inspirerande och gör att man gärna vill söka mer information, och eventuellt bli medlem hos oss. Temat borde vara att "utforska". Vi tänker oss ett galleri där man kan välja en drönare, se information om den, typ när den landade, historien bakom uppskjutandet och kunna se de senaste bilderna från varje drönare.
Med vänliga hälsningar
> Naturhistoriska intressegruppen i Uddebo

I denna uppgift ska du fortsätta med det klientgränssnitt som hämtar data från NASA:s API, men även lägga till funktionaliet från ett eget Webb-API skapat med REST-API, för att demonstera att du kan göra båda delarna.

Ett önskemål från den naturhistoriksa intressegruppen i Uddebo är att visa intressant information om om varje Rover. I denna applikation ska denna information, samt vilka "rovers" som är tillgängliga hämtas från ditt egna Webb-API.
### Kravlista:
* Det inlämande git-repot ska innehålla ett körbart Webb-API skapat med ASP.NET.
* Det inlämnade git-repot ska innehålla ett kliengränsnitt för att interagera med Webb-API:et.
* Det inlämnade Webb-API:et ska innehålla minst 2 åtkomstpunkter.
* Klientgränssnittet ska göra anrop till dessa båda åtkomstpunkter samt minst en åtkomstpunkt i NASA:s Mars Rover Photos API.
* Ett anrop till NASA:s API ska använda sig av data från ett tidigare anrop till det inlämande Webb-API:et.
* En av åtkomstpunkterna i det inlämnade Webb-API:et ska kräva att en parameter anges, exempelvis en rymdsonds id eller namn.
* Från en av åtkomstpunkerna leveras information om rymdsonden som inte finns tillgänglig i NASAs API.
