using System;

using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Content
{
	public class ContentManager : IDisposable
	{
		public String RootDirectory { get; set; }
		public IServiceProvider ServiceProvider { get; set; }
		
		
		public ContentManager ( )
		{
		}
		
		public ContentManager ( IServiceProvider serviceProvider )
		{
			ServiceProvider = serviceProvider;
		}
		
		public ContentManager ( IServiceProvider serviceProvider, string rootDirectory )
		{
			RootDirectory = rootDirectory;	
			ServiceProvider = serviceProvider;
		}
		
		public void Dispose()
		{
		}
		
		
		public virtual T Load<T> ( string assetName )
		{
			string path = RootDirectory + "/" + assetName;
			
			Console.Write("ContentManager::Load '"+path+"' ");
			
			/* Load a texture as an opengl texture */
			if( typeof(T) == typeof(Texture2D) )
			{
				
				Console.Write("(Texture2D)... ");
				
			}
			else 
			{
				Console.Write("(Unknown type)... Error\n");
			}
			
			return default(T);
		}
		
		
		/* Dispose all data */
		public virtual void Unload ()
		{
			
		}
		
		protected T ReadAsset<T> ( string assetName, 
		                           Action<IDisposable> recordDisposableObject )
		{
			return default(T);
		}

		/*
		protected virtual Stream OpenStream ( string assetName )
		{
		}
		*/
	}

}

