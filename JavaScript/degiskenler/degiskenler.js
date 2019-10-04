/*
var yil = 2019;

var dogum = prompt("Doğum Yılınızı Giriniz: ");

var yas = yil - dogum

if(yas >= 18){
    console.log("Yaşınız: "+yas+". Ehliyet Alabilirsiniz.");
}else{
    console.log("Yaşınız: "+yas+". Ehliyet ALAMAZSINIZ!");
}

var ay = prompt("Herhangi bir ayı sayı ile giriniz (Mevsim bulunacak) : ");
switch(ay){
    case '1':
    case '2':
    case '12':
        console.log("Kış Mevsimi");
        break;
    
    case '3':
    case '4':
    case '5':
        console.log("İlkbahar Mevsimi");
        break;

    case '6':
    case '7':
    case '8':
        console.log("Yaz Mevsimi");
    break;

    case '9':
    case '10':
    case '11':
        console.log("Sonbahar Mevsimi");
    break;
}
*/

/*
var sehirler = 
["kocaeli","istanbul","izmir","adana"];
*/

/*

for (var i=0; i < sehirler.length; i++){
    console.log(sehirler[i]);
}



var i=0;
while(i<10){
    console.log(i);
    i++;
}


var i=0;
while(i < sehirler.length){
    console.log(sehirler[i]);
    i++;
}


for (var i = 0; i <= 100; i++){
    if(i == 50){
        continue;
    }
    console.log(i);
}
*/

/*
var k_username = "guest";
var k_password = "12345";

var username = prompt("Kullanıcı Adı: ");
var password = prompt("Parola: ");

if((k_username == username) && (k_password == password)){
    console.log("Giriş Yapıldı.");
}else{
    console.log("Hatalı Kullanıcı adı veya Parola");
}
*/

/*
var marka = ['Opel','Toyota','Mazda'];
var model = ['Corsa','Yaris','CS-3'];
var yil = ['2015','2012','2016'];

console.log(marka[0] + ' ' + model[0] + ' ' + yil[0]);
*/
/*
var ali = {
    ad: 'Ali',
    soyad: 'Yılmaz',
    cinsiyet: 'Erkek',
    telefon: '026233333',
    adres: 'İzmit Kocaeli',
    meslek: 'Bilgisayar Mühendisi',
    diller: ['İngilizce','Almanca'],
    hobiler: ['Sinema','Spor','Kitap Okumak']
};

console.log(ali.diller.length);

ali.hobiler.forEach(function(hobi){
    console.log(hobi);
});

var personel = [
    {
        ad: 'Ali',
        soyad: 'Yılmaz',
        cinsiyet: 'Erkek',
        telefon: '026233333',
        adres: 'İzmit Kocaeli',
        meslek: 'Bilgisayar Mühendisi',
        diller: ['İngilizce','Almanca'],
        hobiler: ['Sinema','Spor','Kitap Okumak']
    },

    {
        ad: 'Hasan Ali',
        soyad: 'Kara',
        cinsiyet: 'Erkek',
        telefon: '024446788',
        adres: 'Şarköy Tekirdağ',
        meslek: 'Yazılım Mühendisi',
        diller: ['İngilizce','Almanca'],
        hobiler: ['Sinema','Bisiklet','Seyahat']
    },

    {
        ad: 'Dilara',
        soyad: 'Beğdili',
        cinsiyet: 'Kız',
        telefon: '026233333',
        adres: 'Sivas Divriği',
        meslek: 'Tasarımcı',
        diller: ['İngilizce','Almanca'],
        hobiler: ['Sinema','Spor','Kitap Okumak']
    },




];
personel.forEach(function(personel){
    console.log(personel);

    personel.diller.forEach(function(dil){
        console.log(dil);
    });
});

*/



