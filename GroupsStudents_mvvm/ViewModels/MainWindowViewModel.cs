using GroupsStudents_mvvm.Models;
using GroupsStudents_mvvm.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsStudents_mvvm.ViewModels
{
    class MainWindowViewModel:ViewModel
    {
        public ObservableCollection<Group> Groups { get; }

        #region Выбранная группа

        private Group _SelectedGroup;

        public Group SelectedGroup
        {
            get => _SelectedGroup;
            set => Set<Group>(ref _SelectedGroup, value);
        }


        #endregion




        public MainWindowViewModel()
        {
            var students = Enumerable.Range(1, 10).Select(j => new Student()
            {
                Name = $"Имя{j}",
                Surname = $"Фамилия{j}",
                Patronymic = $"Отчество{j}",
                Rating = 0
            });
            var groups = Enumerable.Range(1, 20).Select
                (i => new Group()
                    { 
                        Name = $"Группа {i}", 
                        Students=new ObservableCollection<Student>(students) 
                    }
                );
            Groups = new ObservableCollection<Group>(groups);

        }

    }
}
