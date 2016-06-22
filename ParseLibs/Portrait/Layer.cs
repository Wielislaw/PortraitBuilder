using System.Collections.Generic;
using System.Drawing;

namespace Parsers.Portrait {

	/// <summary>
	/// Portrait images are drawn as a succession of layers
	/// 
	/// Note: multiple layers may contribute to render the same portrait attribute (E.g. clothes_behind, clothes, clothes_infront).
	/// </summary>
	public class Layer {
		/// <summary>
		/// The name of the layer (E.g GFX_character_background)
		/// </summary>
		public string Name;

		/// <summary>
		/// Index of the letter in the DNA/Properties string
		/// </summary>
		public int Index;

		public Type LayerType;

		public bool IsHair;
		public bool IsEye;
		public bool DontRefreshIfValid = false;

		/// <summary>
		/// The offset coordinates for this layer, from the bottom-left of the image
		/// </summary>
		public Point Offset = new Point(0, 0);

		public enum Type {
			DNA,
			Property
		}

		/// <summary>
		/// The file that the data was loaded from.
		/// </summary>
		public string Filename;

		public override string ToString() {
			return string.Format("Name: {0}, Index: {1}, LayerType: {2}, Offset: {3}, Hair: {4}, Eye: {5}", Name, Index, LayerType, Offset, IsHair, IsEye);
		}
	}
}