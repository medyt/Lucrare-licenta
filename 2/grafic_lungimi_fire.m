clear all;
ax1 = subplot(1,1,1);
x = logspace(0,1);
y = (x/2.^2*0.1)/((0.155).^2);

plot(ax1,x,y,'-s')
grid on
title(ax1,'Graficul greutatii unui metru liniar de fir')
ylabel(ax1,'masa metru fir')
xlabel(ax1,'grosime fir')
