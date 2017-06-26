clear all;
h=input('Care este inaltimea de la lanul apei la varful lansetei?');
l=input('Care este lungimea firului lansat?');
alpha=input('Care este marimea in grade a unghiului format de varful lansetei si planul apei?');
x=l*cos(alpha)-h;
fprintf('Pestele se afla la adancimea de %f\n',x);
ip=(l*x)/(h+x);
fprintf('Pentru a ajunge la aer pestele mai are nevoie de %f\n',ip);


