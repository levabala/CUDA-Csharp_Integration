#include "cuda_runtime.h"
#include <math.h>

void SimpleSummator(double* a, double* b, double* c, int length){
	for (int i = 0; i < length; i++){
		c[i] = sinf(a[i]) + sinf(b[i]);
	 }
}

__global__ void CUDASummator(double* a, double* b, double* c){
	int i = threadIdx.x + blockIdx.x * blockDim.x;
	c[i] = sinf(a[i]) + sinf(b[i]);	
}

__global__ void CUDASinusator(double* a, double* result){
	int i = threadIdx.x + blockIdx.x * blockDim.x;
	result[i] = sinf(a[i]);	
}

__global__ void RangeSummator(double* a, double* b, double* c, int bottomB){
	int i = threadIdx.x + blockIdx.x * blockDim.x;
	c[i] = sinf(a[i]);	
}

int GPU_Sinusator(double* a, double* result, int length){
	double* dev_a;	
	double* dev_result;

	cudaMalloc((void**)&dev_a, length * sizeof(double));	
	cudaMalloc((void**)&dev_result, length * sizeof(double));		

	cudaMemcpy(dev_a, a, length * sizeof(double), cudaMemcpyHostToDevice);	
	CUDASinusator<<<100,length/100>>>(dev_a,dev_result);
	cudaMemcpy(result,dev_result,length * sizeof(double), cudaMemcpyDeviceToHost);

	cudaFree(dev_a);	
	cudaFree(dev_result);
	return 9999;
}

int count = 100;
int GPU_Summator(double* a, double* b, double* c, int length, int type){
	if (type == 1) {
		SimpleSummator(a,b,c,length);
		return 11111;
	}
	if (type == 2) {
		double* dev_a;
		double* dev_b;
		double* dev_c;
		
		float elapsed=0;
		cudaEvent_t start, stop;

		cudaEventCreate(&start);
		cudaEventCreate(&stop);

		cudaEventRecord(start, 0);

		cudaMalloc((void**)&dev_a, length * sizeof(double));
		cudaMalloc((void**)&dev_b, length * sizeof(double)); 
		cudaMalloc((void**)&dev_c, length * sizeof(double));		

		cudaMemcpy(dev_a, a, length * sizeof(double), cudaMemcpyHostToDevice);
		cudaMemcpy(dev_b, b, length * sizeof(double), cudaMemcpyHostToDevice);
		CUDASummator<<<count,length/count>>>(dev_a,dev_b,dev_c);
		cudaMemcpy(c,dev_c,length * sizeof(double), cudaMemcpyDeviceToHost);

		cudaFree(dev_a);
		cudaFree(dev_b);
		cudaFree(dev_c);

		cudaEventRecord(stop, 0);
		cudaEventSynchronize (stop);

		cudaEventElapsedTime(&elapsed, start, stop);

		cudaEventDestroy(start);
		cudaEventDestroy(stop);

		return (int)(elapsed*1000);
	}
	int repeatC = 4;
	float el;
	if (type == 3){
		float bestT = 10000.0;
		float bestC = 10;
		for (int i = 10; i < 1000; i+=10){
			el = 0.0;
			for (int r = 0; r < repeatC; r++){
				double* dev_a;
				double* dev_b;
				double* dev_c;
		
				float elapsed=0;
				cudaEvent_t start, stop;

				cudaEventCreate(&start);
				cudaEventCreate(&stop);

				cudaEventRecord(start, 0);

				cudaMalloc((void**)&dev_a, length * sizeof(double));
				cudaMalloc((void**)&dev_b, length * sizeof(double)); 
				cudaMalloc((void**)&dev_c, length * sizeof(double));		

				cudaMemcpy(dev_a, a, length * sizeof(double), cudaMemcpyHostToDevice);
				cudaMemcpy(dev_b, b, length * sizeof(double), cudaMemcpyHostToDevice);
				CUDASummator<<<i,length/i>>>(dev_a,dev_b,dev_c);
				cudaMemcpy(c,dev_c,length * sizeof(double), cudaMemcpyDeviceToHost);

				cudaFree(dev_a);
				cudaFree(dev_b);
				cudaFree(dev_c);

				cudaEventRecord(stop, 0);
				cudaEventSynchronize (stop);

				cudaEventElapsedTime(&elapsed, start, stop);

				cudaEventDestroy(start);
				cudaEventDestroy(stop);
				el += elapsed;
			}
			if (el/repeatC < bestT) {
				bestT = el/repeatC;
				bestC = i;
			}
		}
		return bestC;
	}
	return 99999;
};