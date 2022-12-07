--Mi MADAGASZKÁR fővárosa?
SELECT fovaros FROM orszagok WHERE orszag LIKE 'MADAGASZKÁR';
--Melyik ország fővárosa OUAGADOUGOU? 
SELECT orszag FROM orszagok WHERE fovaros LIKE 'OUAGADOUGOU';
--Melyik ország autójele a TT?
SELECT orszag FROM orszagok WHERE autojel LIKE 'TT'; 
--Melyik ország pénzének jele az SGD?
SELECT orszag FROM orszagok WHERE penznem LIKE 'SGD'; 
--Melyik ország nemzetközi telefon-hívószáma a 61?
SELECT orszag FROM orszagok WHERE telefon = 61; 
--Mekkora területű Monaco?
SELECT terulet FROM orszagok WHERE orszag LIKE 'Monaco';
--Hányan laknak Máltán? 
SELECT nepesseg*1000 FROM orszagok WHERE orszag LIKE 'Málta'; 
--Mennyi Japán népsűrűsége? 
SELECT nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok WHERE orszag LIKE 'Japán';
--Hány lakosa van a Földnek? 
SELECT SUM(nepesseg*1000) FROM orszagok;
--Mennyi az országok területe összesen?
SELECT SUM(terulet) FROM orszagok;
--Mennyi az országok átlagos népessége? 
SELECT AVG(nepesseg*1000) FROM orszagok;
--Mennyi az országok átlagos területe?
SELECT AVG(terulet) FROM orszagok;
--Mennyi a Föld népsűrűsége?
SELECT nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok
--Hány 1.000.000 km2-nél nagyobb területű ország van? 
SELECT Count(Id) FROM orszagok WHERE terulet>1000000;
--Hány 100 km2-nél kisebb területű ország van?
SELECT COUNT(Id) FROM orszagok WHERE terulet<100;
--Hány 20.000 főnél kevesebb lakosú ország van?
SELECT Count(Id) FROM orszagok WHERE nepesseg<20;
--Hány országra igaz, hogy területe kisebb 100 km2-nél, vagy pedig a lakossága kevesebb 20.000 főnél?
SELECT Count(Id) FROM orszagok WHERE terulet<100 OR nepesseg<20;
--Hány ország területe 50.000 és 150.000 km2 közötti? 
SELECT Count(Id) FROM orszagok WHERE terulet BETWEEN 50000 AND 150000;
--Hány ország lakossága 8 és 12 millió közötti?
SELECT Count(Id) FROM orszagok WHERE nepesseg BETWEEN 8000 AND 12000;
--Mely fővárosok népesebbek 20 millió főnél?
SELECT Fovaros FROM orszagok WHERE Nep_fovaros>20000;
--Mely országok népsűrűsége nagyobb 500 fő/km2-nél?
SELECT orszagok,nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok WHERE Népsűrűség>500
--Hány ország államformája köztársaság?
SELECT COUNT(Id) FROM orszagok WHERE allamforma LIKE 'Köztársaság';
--Mely országok pénzneme a kelet-karib dollár?
SELECT orszag FROM orszagok WHERE penznem LIKE 'kelet-karib';
--Hány ország nevében van benne az "ORSZÁG" szó? 
SELECT COUNT(id) FROM orszagok WHERE orszag LIKE '%ország%'
--Mely országokban korona a hivatalos fizetőeszköz?
SELECT orszag FROM orszagok WHERE penznem LIKE 'Korona';
--Mennyi Európa területe?
SELECT SUM(terulet) FROM orszagok WHERE foldr_hely LIKE '%európa%';
--Mennyi Európa lakossága?
SELECT SUM(nepesseg*1000) FROM orszagok WHERE foldr_hely LIKE '%európa%';
--Mennyi Európa népsűrűsége?
SELECT nepesseg*1000/terulet FROM orszagok WHERE foldr_hely LIKE '%európa%';
--Hány ország van Afrikában?
SELECT COUNT(Id) FROM orszagok WHERE foldr_hely LIKE '%Afrika%';
--Mennyi Afrika lakossága?
SELECT nepesseg*1000 FROM orszagok WHERE foldr_hely LIKE '%Afrika%';
--Mennyi Afrika népsűrűsége?
SELECT nepesseg*1000/terulet FROM orszagok WHERE foldr_hely LIKE '%Afrika%';
--Melyek a szigetországok? 
SELECT orszag FROM orszagok WHERE foldr_hely LIKE '%szigetország%';
--Mely országok államformája hercegség, vagy királyság?
SELECT orszag FROM orszagok WHERE allamforma LIKE '%hercegség%' OR allamforma LIKE '%királyság%';
--Hány országnak nincs autójelzése?
SELECT COUNT(Id) FROM orszagok WHERE autojel is null;
--Mennyi a váltószáma az aprópénznek azokban az országokban, ahol nem 100?
SELECT valtopenz FROM orszagok WHERE valtopenz NOT LIKE '%100%';
--Hány ország területe kisebb Magyarországénál? 
SELECT COUNT(Id) FROM orszagok WHERE terulet<IN(SELECT terulet FROM orszagok WHERE orszag LIKE 'Magyarország');
--Melyik a legnagyobb területű ország, és mennyi a területe? 
SELECT orszag, terulet FROM orszagok ORDER BY terulet DESC LIMIT 1;
--Melyik a legkisebb területű ország, és mennyi a területe?
SELECT orszag, terulet FROM orszagok ORDER BY terulet ASC LIMIT 1;
--Melyik a legnépesebb ország, és hány lakosa van?
SELECT orszag, nepesseg*1000 FROM orszagok ORDER BY nepesseg DESC LIMIT 1;
--Melyik a legkisebb népességű ország, és hány lakosa van?
SELECT orszag, nepesseg*1000 FROM orszagok ORDER BY nepesseg ASC LIMIT 1;
--Melyik a legsűrűbben lakott ország, és mennyi a népsűrűsége?
SELECT orszag, nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok ORDER BY Népsűrűség DESC LIMIT 1;
--Melyik a legritkábban lakott ország, és mennyi a népsűrűsége?
SELECT orszag, nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok ORDER BY Népsűrűség ASC LIMIT 1;
--Melyik a legnagyobb afrikai ország és mekkora?
SELECT orszag, terulet FROM orszagok WHERE foldr_hely LIKE '%Afrika%'  ORDER BY terulet DESC LIMIT 1;
--Melyik a legkisebb amerikai ország és hányan lakják?
SELECT orszag, nepesseg FROM orszagok WHERE foldr_hely LIKE '%Amerika%'  ORDER BY terulet ASC LIMIT 1;
--Melyik az első három legsűrűbben lakott "országméretű" ország (tehát nem város- vagy törpeállam)? 
SELECT orszag,nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok WHERE foldr_hely NOT LIKE '%városállam%' AND foldr_hely NOT LIKE '%törpeállam%' ORDER BY 'Népsűrűség' DESC LIMIT 3;
--Melyik a világ hat legnépesebb fővárosa?
SELECT fovaros FROM orszagok ORDER BY nep_fovaros DESC LIMIT 6;
--Melyik tíz ország egy főre jutó GDP-je a legnagyobb?
SELECT GDP from orszagok ORDER BY GDP DESC LIMIT 10;
--Melyik tíz ország össz-GDP-je a legnagyobb?
SELECT GDP*(nepesseg*1000)AS 'összGDP' from orszagok ORDER BY összGDP DESC LIMIT 10;
--Melyik országban a legszegényebbek az emberek?
SELECT orszag from orszagok ORDER BY GDP ASC LIMIT 1;
--Melyik a 40. legkisebb területű ország? 
SELECT terulet FROM orszagok ORDER BY terulet ASC LIMIT 39,1; (OFFSET 39)
--Melyik a 15. legkisebb népsűrűségű ország?
SELECT nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok ORDER BY Népsűrűség ASC LIMIT 14,1; (OFFSET 14);
--Melyik a 61. legnagyobb népsűrűségű ország?
SELECT nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok ORDER BY Népsűrűség DESC LIMIT 60,1; (OFFSET 60);
Melyik három ország területe hasonlít leginkább Magyaroszág méretéhez?  
--Az emberek hányadrésze él Ázsiában?
SELECT SUM(nepesseg)/(SELECT SUM(nepesseg) FROM orszagok) FROM orszagok WHERE foldr_hely LIKE '%Ázsia%';
--A szárazföldek mekkora hányadát foglalja el Oroszország?
SELECT SUM(terulet)/(SELECT terulet FROM orszagok WHERE orszag LIKE 'Oroszország') FROM orszagok WHERE foldr_hely LIKE '%Ázsia%';
Az emberek hány százaléka fizet euroval?
--Hányszorosa a leggazdagabb ország egy főre jutó GDP-je a legszegényebb ország egy főre jutó GDP-jének?
SELECT MAX(GDP)/MIN(GDP) FROM orszagok;
A világ össz-GDP-jének hány százalékát adja az USA?
A világ össz-GDP-jének hány százalékát adja az euroövezet?
Melyek azok az átlagnál gazdagabb országok, amelyek nem az európai vagy az amerikai kontinensen találhatóak?
Milyen államformák léteznek Európában? 
Hányféle államforma létezik a világon? 
Hányféle fizetőeszközt használnak Európában az eurón kívül?
Mely pénznemeket használják több országban is?   
Mely országok államformája egyedi?  