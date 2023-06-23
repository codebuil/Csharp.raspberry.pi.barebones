namespace os
{
	public class oss
	{	public static int rgb(int r, int g,int b){
				return (r & 63)<<11 | (g & 63) << 5 | (b & 63);
		}
		unsafe public static void hline(int x,int y, int x2,int colorss) 
		{
			int f;
			int xx1=x;
			int xx2=x2;
			int xx3=x;
			int yy=y;
			int steeps;
			int location;
			int addss;
			char *fbp=(char * )0x04100000;
			   int ii=colorss & 0xff;
			   int iii=((colorss >> 8) & 0xff);
			   char c1=(char) ii;
			   char c2=(char) iii;

			if(xx2<xx1){
				xx1=xx2;
				xx2=xx3;
			}
			if(yy<0)yy=0;
			if(yy>479)yy=479;
			if(xx1<0)xx1=0;
			if(xx2<0)xx2=0;
			if(xx1>639)xx1=639;
			if(xx2>639)xx2=639;
                       
			location =  (640 *2) * y + (x*2);
			steeps=xx2-xx1;
			addss=1;
			for(f=0;f<steeps;f++){
 			    *((char *)(fbp + + location)) =c1;
			    *((char *)(fbp + + location+1)) =c2;
		
				location=location+addss;
			}
		
		
		}
		unsafe public static void clear(int colorss) 
		  {
			  			   // Clear the screen 
			   int ii=colorss & 0xff;
			   int iii=((colorss >> 8) & 0xff);
			   char c1=(char) ii;
			   char c2=(char) iii;
			   char *fbp=(char * )0x04100000;
			   for(int i = 0; i < 640 * 480 * 2 ; i=i+2){
			    *((char *)(fbp + i)) =c1;
			    *((char *)(fbp + i+1)) =c2;
			    
			   
			}
		  }
		  public static void kernel_main() 
		  {
			   // Clear the screen 
			int color1=rgb(0,0,63);
			int color2=rgb(0,0,0);
			int n=0;
			clear(color1);
			for(n=0;n<479;n=n+8)hline(0,n,639,color2);
			while(true){}
			} 

		  public static void Main() 
		  {
			 kernel_main();
			}  
	    
		


}

}
