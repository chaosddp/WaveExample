using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Framework;

namespace Share
{
    public abstract class Template
    {
        public string Name { get; protected set; }

        public Template(string name)
        {
            this.Name = name;
        }

        public abstract Entity Create();
    }

    public class TemplateManager
    {
        private TemplateManager() { }

        private static TemplateManager _instance;

        public static TemplateManager Instance
        {

            get
            {
                if (_instance == null) _instance = new TemplateManager();

                return _instance;
            }
        }

        private Dictionary<string, Template> _template = new Dictionary<string, Template>();

        public Entity Create(string name)
        {

            if (string.IsNullOrWhiteSpace(name) || !_template.ContainsKey(name))
                throw new ArgumentException("template name not valid or not exist.");

            return _template[name].Create();
        }

        public void Add<T>() where T : Template
        {
            var template = Activator.CreateInstance<T>();

            if (template == null || string.IsNullOrWhiteSpace(template.Name) || _template.ContainsKey(template.Name))
                throw new ArgumentException("template not valid or already exist");

            _template.Add(template.Name, template);
        }
    }
}
