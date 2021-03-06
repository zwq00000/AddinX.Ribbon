﻿using System;
using System.Xml.Linq;
using AddinX.Fluent.Impl.Command;
using AddinX.Fluent.Impl.Ribbon;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Gallery : Control<IGallery, IGalleryCommand>, IGallery {
        private bool _dynamicItemsLoading;
        private readonly Items _data;
        private readonly Controls _buttons;

        public Gallery() : base("gallery") {
            _data = new Items();
            NormalSize();
            _buttons = new Controls();
            NoImage();
            SizeString(7);
        }

        protected internal override void SetRegister(ICallbackRegister register) {
            base.SetRegister(register);
            _data.SetRegister(register);
            _buttons.SetRegister(register);
        }

        protected internal override XElement ToXml(XNamespace ns) {
            var element = base.ToXml(ns);
            if (!_dynamicItemsLoading) {
                element.AddControls(_data, ns);
            }
            // Then the buttons
            element.AddControls(_buttons, ns);

            return element;
        }

        protected override IGallery Interface => this;


        public IGallery DynamicItems() {
            _dynamicItemsLoading = true;
            return this;
        }


        public IGallery Items(Action<IItems> builder) {
            _dynamicItemsLoading = false;
            builder.Invoke(_data);
            return this;
        }

        public IGallery Buttons(Action<IGalleryControls> items) {
            items.Invoke(_buttons);
            return this;
        }

        #region Implementation of IRibbonCallback<out IGallery,out IGalleryCommand>

        public void Callback(Action<IGalleryCommand> builder) {
            builder(GetCommand<GalleryCommand>());
        }

        #endregion
    }
}