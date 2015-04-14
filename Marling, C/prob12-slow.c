#include<stdio.h>
int main(){
  int triangle=1,inc,factors=0;
  for(inc=2;factors<500;inc++) {
  	triangle+=inc;
  	factors=1;
    int i;
  	for(i=1;i<triangle;i++){
  		if(triangle % i ==0) factors++;
  	}
    if (factors>100)//some others for fun
      printf("%d has %d factors\n",triangle,factors);
  }
  printf("%d has %d factors\n",triangle,factors);
  return 0;
}
