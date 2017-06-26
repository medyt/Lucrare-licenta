clear all;
raza_actiune_tambur=input('Care este raza de actiune a tamburului?');
numar_spire_initiale=input('Care este numarul initial de spire?');
dim_spira_initiala=input('Care este dimensiunea unei spire initiale?');	
dim_fir=input('Care este dimensiunea firului utilizat?');
lungimea_fir_tambur=0;
pas = dim_fir * 2 / 10;
dim_spira=dim_spira_initiala;
while raza_actiune_tambur>0
	lungimea_fir_tambur= lungimea_fir_tambur+ numar_spire_initiale*dim_spira_initiala / 100;
    dim_spira_initiala =dim_spira_initiala+ pas;
	raza_actiune_tambur =raza_actiune_tambur- dim_fir;
end    
disp(lungimea_fir_tambur);

dim_umpluta=input('Care este raza ocupata cu fir dupa aplicarea firului pe tambur?');
dim_spira_initiala=dim_spira;
lungimea_fir_tambur_plin=0;
while dim_umpluta>0
	lungimea_fir_tambur_plin= lungimea_fir_tambur_plin+ numar_spire_initiale*dim_spira_initiala / 100;
    dim_spira_initiala =dim_spira_initiala+ pas;
	dim_umpluta =dim_umpluta- dim_fir;
end    
disp(lungimea_fir_tambur_plin);

dim_u=input('Care este raza ocupata cu fir dupa aruncare?');
dim_spira_initiala=dim_spira;
lungimea_fir_tambur_final=0;
while dim_u>0
	lungimea_fir_tambur_final= lungimea_fir_tambur_final+ numar_spire_initiale*dim_spira_initiala / 100;
    dim_spira_initiala =dim_spira_initiala+ pas;
	dim_u =dim_u- dim_fir;
end    
disp(lungimea_fir_tambur_final);
lungime_fir_aruncat=lungimea_fir_tambur_plin-lungimea_fir_tambur_final;
fprintf('Bravo, ai aruncat: %f\n',lungime_fir_aruncat); 
timp1=input('Care este timpul pe care l-a parcurs montura pana la impactul cu apa?');
timp0=0;
dist0=0;
dist1=lungime_fir_aruncat;
viteza=(dist1-dist0)/(timp1-timp0);
fprintf('Viteza pe care ai reusit sa o impui greutatii este: %f  m/s\n',viteza);
acceleratia=viteza/timp1;
fprintf('Acceleratia masurata in timpul aruncarii este: %f\n',acceleratia);
masa_aruncata=input('Care este greutatea monturii?');
forta_lansare=masa_aruncata*acceleratia;
fprintf('Forta de lansare este %f\n',forta_lansare);