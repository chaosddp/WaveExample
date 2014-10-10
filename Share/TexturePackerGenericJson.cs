
#region Using Statements
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using WaveEngine.Common.Math;
using WaveEngine.Components.Animation;
using WaveEngine.Framework.Services;
#endregion

namespace Share
{
    /// <summary>
    /// Texture Packer's Generic XML sprite sheet loader.
    /// </summary>
    public class TexturePackerGenericJson : ISpriteSheetLoader
    {
        /// <summary>
        /// Parses the passed XML looking for frame info.
        /// </summary>
        /// <param name="path">Path to the json.</param>
        /// <returns>Array of <see cref="Rectangle"/>.</returns>
        public Rectangle[] Parse(string path)
        {
            JObject settings = null;

            // change it to using StreamReader, so that i do not need to change to when convert to WP
            using (var stream = WaveServices.Storage.OpenContentFile(path))
            {
                using (var reader = new StreamReader(stream))
                {
                    settings = JObject.Parse(reader.ReadToEnd());
                }
            }

            var frames = settings["frames"].Select(frame => new Rectangle()
            {
                X = frame["frame"]["x"].Value<int>(),
                Y = frame["frame"]["y"].Value<int>(),
                Width = frame["frame"]["w"].Value<int>(),
                Height = frame["frame"]["h"].Value<int>()
            }).ToArray();

            return frames;
        }
    }
}