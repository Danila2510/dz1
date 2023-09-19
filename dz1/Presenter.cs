using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.EventLoad += new EventHandler<EventArgs>(OnLoad);
            _view.EventSave += new EventHandler<EventArgs>(OnSave);
            _view.EventSearch += new EventHandler<EventArgs>(OnSearch);
        }

        private void UpdateView()
        {
            _model.Load();
            _view.rezon = _model.Result;
        }

        private void OnSave(object sender, EventArgs e)
        {
            _model.Result = "Name: " + _view.imya + ", Age: " + _view.vozrast;
            _model.Save();
            UpdateView();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _model.Load();
            _view.rezon = _model.Result;
        }
        private void OnSearch(object sender, EventArgs e)
        {
            _model.Result = _view.poisk;
            _model.Search();
            _view.rezon = _model.Result;
        }
    }
}
