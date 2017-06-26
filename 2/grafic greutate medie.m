clear all;
ax1 = subplot(1,1,1);
x = logspace(0,1);
distanta=unifrnd(50,150);
y = (x/2.^2*0.1)/((0.155).^2);
z = 2*distanta*y;
plot3(ax1,x,y,z,'-s')
grid on
title(ax1,'Graficul greutatii minime de aruncare')
ylabel(ax1,'masa metru fir')
xlabel(ax1,'grosime fir')
zlabel(ax1,'greutate minima')