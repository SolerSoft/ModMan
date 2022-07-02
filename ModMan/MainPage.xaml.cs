﻿using ModMan.Data;
using ModMan.Providers;
using Serilog;

namespace ModMan;

public partial class MainPage : ContentPage
{
    #region Private Fields

    private int count = 0;

    #endregion Private Fields

    #region Public Constructors

    public MainPage()
    {
        InitializeComponent();
        var t = LoadDataAsync();
    }

    #endregion Public Constructors

    #region Private Methods

    private async Task LoadDataAsync()
    {
        // Just use EdgeTX for now
        IProfileProvider provider = new Providers.EdgeTX.ProfileProvider();

        try
        {
            // Get the first profile reference
            var profileReference = (await provider.GetProfilesAsync()).First();
            
            // Load the profile
            var profile = await provider.LoadProfileAsync(profileReference, ProfileLoadOptions.Default);
            
            Log.Debug("Profile loaded.");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Could not load profile.");
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    #endregion Private Methods
}