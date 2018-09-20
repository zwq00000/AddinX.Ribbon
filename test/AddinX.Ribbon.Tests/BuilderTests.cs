﻿using System;
using AddinX.Ribbon.Contract;
using AddinX.Ribbon.Contract.Ribbon.Group;
using AddinX.Ribbon.Implementation;
using AddinX.Ribbon.Implementation.Control;
using NUnit.Framework;

namespace AddinX.Ribbon.Tests {
    internal class BuilderTests {
        private IRibbonBuilder BuildInGroup(Action<IGroupControls> buildAction) {
            var builder = new RibbonBuilder();
            builder.CustomUi.Ribbon.Tabs(
                c => c.AddTab("test").SetId("item1")
                    .Groups(g1 => g1.AddGroup("group").SetId("id")
                        .Items(buildAction)));
            return builder;
        }

        [Test]
        public void BuildButton() {
            var builder = new RibbonBuilder();
            var btn = new Button(builder).Supertip("test").ShowLabel().Description("test button").NoImage()
                .SetId("test_btn");
            builder.CustomUi.Ribbon.Tabs(
                c => c.AddTab("test")
                    .Groups(g1 => g1.AddGroup("group").Items(g => g.AddButton("b")
                        .Callback(cb => cb.OnAction(
                                () => { Console.WriteLine("Test Button"); }
                            ).GetEnabled(() => true)
                        ))));
            Console.WriteLine(builder.GetXmlString());
        }

        [Test]
        public void BuildCheckBox() {
            var builder = new RibbonBuilder();
            builder.CustomUi.Ribbon.Tabs(
                c => c.AddTab("test").SetId("item1")
                    .Groups(g1 => g1.AddGroup("group").SetId("id")
                        .Items(g => g.AddCheckbox("checkbox")
                            .Callback(cb =>
                                cb.OnAction(b => { Console.WriteLine("Test Checkbox press:" + b); }
                                )))));
            Console.WriteLine(builder.GetXmlString());
        }

        [Test]
        public void BuildCombox() {
            var builder = BuildInGroup(i => {
                i.AddComboBox("Colors").SetId("colorsPicking")
                    .ShowLabel().NoImage()
                    .AddItems(o => {
                        o.AddItem("Green").SetId("greenColor");
                        o.AddItem("Red").SetId("redColor").NoImage();
                        o.AddItem("Blue").SetId("blueColor").NoImage();
                    }).Supertip("Color Picking")
                    .MaxLength(15).SizeString(15);
            });

            Console.WriteLine(builder.GetXmlString());
        }
    }
}