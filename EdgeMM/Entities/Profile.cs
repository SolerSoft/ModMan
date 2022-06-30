﻿using System.Collections.ObjectModel;
using IOPath = System.IO.Path;

namespace EdgeMM.Entities
{
    /// <summary>
    /// Represents an EdgeTX profile, often stored on a SD Card.
    /// </summary>
    public class Profile : FileObject
    {
        #region Constants

        private const string MODELS_DIR = "MODELS";
        private const string TEMPLATES_DIR = "TEMPLATES";

        #endregion Constants

        #region Private Fields

        private ObservableCollection<Model> models = new ObservableCollection<Model>();
        private string modelsPath;
        private string name;
        private ObservableCollection<Model> templates = new ObservableCollection<Model>();
        private string templatesPath;

        #endregion Private Fields

        #region Private Methods

        /// <summary>
        /// Updates properties that are based on <see cref="Path" />.
        /// </summary>
        private void UpdatePathProperties()
        {
            ModelsPath = IOPath.Combine(Directory, MODELS_DIR);
            TemplatesPath = IOPath.Combine(Directory, TEMPLATES_DIR);
        }

        #endregion Private Methods

        #region Protected Methods

        /// <inheritdoc />
        protected override void OnPathChanged()
        {
            // Pass to base first
            base.OnPathChanged();

            // Update related
            UpdatePathProperties();
        }

        #endregion Protected Methods

        #region Public Properties

        /// <summary>
        /// Gets or sets the list of models stored within the <see cref="Profile" />.
        /// </summary>
        /// <value>
        /// The list of models stored within the <see cref="Profile" />.
        /// </value>
        public ObservableCollection<Model> Models
        {
            get { return models; }
            set { SetProperty(ref models, value); }
        }

        /// <summary>
        /// Gets the path to the model files stored within the <see cref="Profile" />.
        /// </summary>
        /// <value>
        /// The path to the model files stored within the <see cref="Profile" />.
        /// </value>
        public string ModelsPath
        {
            get { return modelsPath; }
            private set { SetProperty(ref modelsPath, value); }
        }

        /// <summary>
        /// Gets or sets the name of the object.
        /// </summary>
        /// <value>
        /// The name of the object.
        /// </value>
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        /// <summary>
        /// Gets or sets the list of model templates stored within the <see cref="Profile" />.
        /// </summary>
        /// <value>
        /// The list of model templates stored within the <see cref="Profile" />.
        /// </value>
        public ObservableCollection<Model> Templates
        {
            get { return templates; }
            set { SetProperty(ref templates, value); }
        }

        /// <summary>
        /// Gets the path to the template files stored within the <see cref="Profile" />.
        /// </summary>
        /// <value>
        /// The path to the template files stored within the <see cref="Profile" />.
        /// </value>
        public string TemplatesPath
        {
            get { return templatesPath; }
            private set { SetProperty(ref templatesPath, value); }
        }

        #endregion Public Properties
    }
}