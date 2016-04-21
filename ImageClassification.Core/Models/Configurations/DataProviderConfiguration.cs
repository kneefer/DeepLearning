﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Wkiro.ImageClassification.Core.Annotations;

namespace Wkiro.ImageClassification.Core.Models.Configurations
{
    public class DataProviderConfiguration : INotifyPropertyChanged
    {
        private string _trainFilesLocationPath;
        private string[] _fileExtensions;
        
        private int _cropWidth;
        private int _cropHeight;

        public string TrainFilesLocationPath
        {
            get { return _trainFilesLocationPath; }
            set
            {
                _trainFilesLocationPath = value;
                OnPropertyChanged();
            }
        }
        public string[] FileExtensions
        {
            get { return _fileExtensions; }
            set
            {
                _fileExtensions = value;
                OnPropertyChanged();
            }
        }
        
        public int CropWidth
        {
            get { return _cropWidth; }
            set
            {
                _cropWidth = value;
                OnPropertyChanged();
            }
        }
        public int CropHeight
        {
            get { return _cropHeight; }
            set
            {
                _cropHeight = value;
                OnPropertyChanged();
            }
        }

        #region Property changed stuff

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
