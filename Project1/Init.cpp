#include "cudaHeader.h"
extern "C"
 __declspec (dllexport) int  __cdecl   Main(double* a, double* b, double* c, int length, int type)
   { return  GPU_Summator(a,b,c,length,type) ;}