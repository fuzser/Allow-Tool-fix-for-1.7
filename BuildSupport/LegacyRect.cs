namespace UnityEngine {
	/// <summary>
	/// Compile-time shape of the legacy Rect exposed by HugsLib 1.6.
	/// RimWorld 1.7 supplies the runtime compatibility mapping.
	/// </summary>
	public struct Rect {
		public float x { get; set; }
		public float y { get; set; }
		public float width { get; set; }
		public float height { get; set; }

		public Rect(float x, float y, float width, float height) {
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}
	}
}
