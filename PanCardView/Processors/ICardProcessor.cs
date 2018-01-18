﻿using Xamarin.Forms;
using System.Threading.Tasks;
using PanCardView.Enums;

namespace PanCardView.Processors
{
    public interface ICardProcessor
    {
        void InitView(View view, PanItemPosition panItemPosition);
        void HandlePanChanged(View view, double xPos);
        Task HandlePanReset(View view);
        Task HandlePanApply(View view);
    }
}
