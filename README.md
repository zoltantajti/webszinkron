<h1>Webszinkron</h1>
<h3><center>a Joomla VirueMart és a NaturaSoft számlázó között</center></h3>
<b>Függőség: <a href="https://dotnet.microsoft.com/download/dotnet-framework-runtime/net472" target="_blank">.NET Framework 4.7.2</a></b>
<hr />
<h3>2019.03.15. 16:47 -> új feltöltés</h3>
<ul>
  <li>
    Címkeresés előkészítve. Címkezelés menete:
    <ul>
      <li>Ha nincs név, akkor felviszi az adatokat</li>
      <li>Ha van név, de nem egyezik az irányítószám, akkor felviszi az adatokat</li>
      <li>Ha van név, egyezik az irsz, de más az utca, akkor feltölt</li>
      <li>Ha van név, egyezik az irsz + az utca<sup>1</sup> akkor feltölt</li>
      <li>Egyébként kikeresi a NATURA_ID-t.</li>
    </ul>
    <p><sup>1</sup> = Utca, házszám formálása az alábbi formára:<br/>
    Béke út 34. ==> békeu34 (mindent kisbetűvel; szóközök nélkül<br/>
    valamint az út, utca, u cseréje, hogy simán "u" legyen és ha van a végén pont, azt is eltávolítjuk<br/>
    Ezáltal elkerülhető, hogy ugyan azon személy, ugyanazzal a címmel többször szerepeljen az ügyféltörzsben,<br/>
    egyszerű elgépelések miatt.</p>
  </li>
</ul>

<h3>2019.03.15. 13:21 -> új feltöltés</h3>
<ul>
  <li>Árszinkron működik</li>
</ul>

<h3>2019.03.13. 18:57 -> új feltöltés</h3>
<ul>
  <li>Elkezdtem az árak szinkronizálását, de az MSSQL logint kér, holott a rendelések lekérésénél hibátlanul működik. Nem tudom mi lehet a hiba</li>
</ul>

<h3>2019.03.13. 18:57 -> v1.0b verzió</h3>
<ul>
  <li>Nincs értesítés, ha nincs új rendelés</li>
  <li>Telepítéskor parancsikont helyez el az asztalon</li>
</ul>

<h3>2019.03.11. 21:28 -> v0.9b verzió</h3>
<ul>
  <li><b>Új rendelések letöltése</b></li>
  <li>Windows 7 x86/x64 és Windows 10 x86/x64 kompatibilis</li>
  <li>Optimalizált adatlekérés. Csak a szükséges adatokat tölti be</li>
  <li>MySQL -> MSSQL transzformáció az adatokhoz</li>
  <li>2.61 Mb programméret</li>
</ul>
<hr />
<h3>2019.03.09. 00:47 -> Kódfeltöltés</h3>
<ul>
  <li>Bekerült a license-lés minden függőségével</li>
  <li>Bekerült az adatbázis motor osztálya (funckiók nélkül)</li>
  <li>Bekerült az értesítési buborék</li>
  <li>Hitelesítést kapott Windows 10 alá</li>
  <li>x86-x64 kompatibilis</li>
</ul>
<hr />
<h3>2019.03.08. 21:30 -> Első feltöltés</h3>
<b>Visual Studio, Windows Form Application alapkód</b>
