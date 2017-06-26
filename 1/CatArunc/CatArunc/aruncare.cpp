#include<fstream> 
using namespace std;
ifstream intrare("lungime.in");
ofstream iesire("lungime.out");
double raza_actiune_tambur;
double numar_spire_initiale;
double dim_spira_initiala;
double dim_fir;
int main()
{
	intrare >> raza_actiune_tambur;//citesc spatiul gol ca fiid diferenta dintre raza 
								   //tamburului si spatiul nefolosit pentru fir
	intrare >> numar_spire_initiale;//cate spire de fir incap initial pe tambur
	intrare >> dim_spira_initiala;//dimensiunea spirei initiale
	intrare >> dim_fir;//dimensiunea firului
	double dim_fir_tambur = 0;
	double pas;
	pas = dim_fir * 2 / 10;
	while (raza_actiune_tambur>0)
	{
		dim_fir_tambur += numar_spire_initiale*dim_spira_initiala / 100;
		//consider ca numarul de spire ramane acelasi;		
		dim_spira_initiala += pas;
		raza_actiune_tambur -= dim_fir;
	}
	iesire << dim_fir_tambur << '\n';
	iesire.close();
	return 0;
}