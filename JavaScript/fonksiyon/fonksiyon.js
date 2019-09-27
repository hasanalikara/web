/*

function topla(a,b){
    return a+b;
}

var sonuc = topla(10,20);

console.log(sonuc);
console.log(topla(40,50));

*/

/*
SORU 1

var x = prompt("Bir Sayı Giriniz: ");
function tekcifthesaplama(DNG){
    if(DNG % 2 == 0){
        return true;
    }else{
        return false;
    }
}
var sayi = tekcifthesaplama(x);
console.log(sayi);
*/



var sayi = prompt("Bir sayı giriniz: ");
var sonuc = 1;
function faktoriyel(fak){
    for(i = 1; i <= fak; i++){
        sonuc *= i;
    }
    return sonuc;
}
var s =  faktoriyel(sayi);
console.log(s);
