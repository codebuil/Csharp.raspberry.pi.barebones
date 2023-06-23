namespace os
{
	public class oss
	{	public static int rgb(int r, int g,int b){
				return (r & 63)<<11 | (g & 63) << 5 | (b & 63);
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
			clear(color1);
			while(true){}
			} 

		  public static void Main() 
		  {
			 kernel_main();
			}  
	    
		


}

}
