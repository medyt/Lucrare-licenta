clear all;
distanta_aruncata=input('Care este distanta la care ati aruncat?\n');
grosime_fir=input('Care este grosimea firului utilizat?\n');
greutate_metru_fir=(((grosime_fir/2)^2)*0.1)/((0.155)^2);
masa_fir_intins=2*distanta_aruncata*greutate_metru_fir
fprintf('Greutatea pentru care firul sta intins la distanta %f m este de %f g\n',distanta_aruncata,masa_fir_intins);
