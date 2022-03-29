# Test du serveur SOAP :

Pour tester le serveur SOAP, il faut lancer la solution **RenduFinal.sln** et suivre les instructions dans le terminal

# Test du serveur REST :

Pour tester le serveur REST, il faut garder le terminal ouvert précédemment et exécuter via Postman les requêtes suivantes (le format de réponse des requêtes est du JSON)

**Adresses de la requête GET à utiliser sur Postman pour tester le serveur REST :**

Addition de 7+5 (on attend  12 en retour)

    http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Add?x=7&y=5
   
 Multiplication de 7*5 (on attend 35 en retour)

    http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Mult?x=7&y=5

Soustraction de 7-5 (on attend 2 en retour)

    http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Sub?x=7&y=5

Division de 7/5 (on attend 1.4 en retour)

    http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/Div?x=7&y=5
