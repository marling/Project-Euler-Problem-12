#include<stdio.h>
int main(){
  int triangle=1,inc,factors=0;
  for(inc=2;factors < 500;inc++) {
  	triangle+=inc;
  	factors=0;
    int i,sq=sqrt(triangle)+1;//+1 for catching float->int conv
  	for(i=1;i<sq;i++){
  		if(triangle % i ==0) factors+=2;
  	}
    if (factors>100)//some others for fun
      printf("%d has %d factors\n",triangle,factors);
  }
  printf("%d has %d factors\n",triangle,factors);
  return 0;
}
