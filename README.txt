IRF_Project

A programom egy csv fájlból importálja egy telefon szaküzlet elérhető készülékeit.
Ezeknek megjeleníti a típusát, márkáját, illetve az árát. 
A márkánál a csv fájlban csak az adott márkához tartozó azonosító szám látható, ebből iratom ki a márka nevét datagridview-ba get set segítségével.
Valamint az ár értékéhez hozzáfűzöm szintén get set segítségével azt, hogy Ft-ban van.
A Felvetel formon van lehetőség új készülék hozzáadására. Itt az árhoz tartozó textbox-nál van egy validáló függvény, ami csak azt engedi, ha számot írnak bele.
Új termék felvételekor a Felvetel form automatikusan bezáródik és a datagridview a Form1-en frissül az új adatokkal.
Végül pedig egy formázott Excel fájlba lehet exportálni az adatokat. Az Excelben a fejléc, illetve a többi sor különböző módon vannak formázva, a formázás pedig az utolsó adatig tart. Az adatoknál az első oszlop és a második-harmadik oszlop formázása között a szöveg elhelyezkedése a különbség.
Összesen 4 saját osztály van, a legfontosabb a Termek osztály, amiben a fentebb említett setter ágak vannak, emellett van egy Gomb osztály, ami a Form1-en található két gombot formázza és ad hozzájuk 3 eseménykezelőt. A BezarGomb osztály a mindkét formon található piros X gombot formázza, a DGVClass pedig a datagridview-t. 

Éliás Gergely
XD9L9M
