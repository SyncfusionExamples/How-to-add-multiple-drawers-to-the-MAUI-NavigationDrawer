### Overview

The [.NET MAUI Navigation Drawer](https://www.syncfusion.com/maui-controls/maui-navigationdrawer) allows users to open the drawer on multiple sides with different toggle methods. The multiple drawers can be implemented using the following drawer settings.

 * [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings)
 * [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) 

 The secondary drawer provides a separate panel for displaying complementary content and actions that support the main navigation, allowing you to organize secondary features, contextual tools, or additional information independently while keeping the Primary Drawer focused on core navigation without cluttering the interface.

This article explains how to add multiple drawers to the Navigation Drawer.  
 
To add multiple drawers in the Navigation Drawer, follow these steps:
 
1. Add a Navigation Drawer and include the  [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) for the primary drawer, and  [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) for the secondary drawer.
2. Each drawer can be provided with separate [DrawerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView), [DrawerContentView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView) and [DrawerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView).
 
```
<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.ContentView>
        <Grid RowDefinitions="80, *">
            <Grid BackgroundColor="#6750A4" ColumnDefinitions="*, *">
                <Button Text="&#xe719;" Clicked="OnPrimaryDrawerToggled" FontFamily="MauiMaterialAssets" FontAttributes="Bold" TextColor="White" FontSize="24" BackgroundColor="Transparent" HorizontalOptions="Start" Grid.Column="0" />
                <Button Text="&#xe716;" Clicked="OnSecondaryDrawerToggled" FontFamily="MauiMaterialAssets" FontAttributes="Bold" TextColor="White" FontSize="24" BackgroundColor="Transparent" HorizontalOptions="End" Grid.Column="1" />
            </Grid>
            <Label Grid.Row="1" Text="Main Content" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" Margin="16" />
        </Grid>
    </navigationDrawer:SfNavigationDrawer.ContentView>

    <!-- Primary drawer settings -->
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings Position="Left" DrawerWidth="300" EnableSwipeGesture="True" Transition="SlideOnTop">
            <navigationDrawer:DrawerSettings.DrawerContentView>
                <ScrollView>
                    <VerticalStackLayout Padding="12" Spacing="2">
                        <Label Text="Mail" FontAttributes="Bold" FontSize="18" VerticalTextAlignment="Center" HorizontalTextAlignment="Center" Margin="12, 0" />
                        <Label Text="Inbox" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Drafts" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Sent" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Starred" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Spam" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Trash" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                    </VerticalStackLayout>
                </ScrollView>
            </navigationDrawer:DrawerSettings.DrawerContentView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>

    <!-- Secondary drawer settings -->
    <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
        <navigationDrawer:DrawerSettings Position="Right" DrawerWidth="300" EnableSwipeGesture="True" Transition="SlideOnTop">
            <navigationDrawer:DrawerSettings.DrawerContentView>
                <ScrollView>
                    <VerticalStackLayout Padding="12" Spacing="2">
                        <Label Text="Settings" FontAttributes="Bold" FontSize="18" VerticalTextAlignment="Center" HorizontalTextAlignment="Center" Margin="12, 0" />
                        <Label Text="Preferences" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Filters" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="Help" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                        <Label Text="About" Padding="12,14" VerticalTextAlignment="Center" FontSize="15" />
                    </VerticalStackLayout>
                </ScrollView>
            </navigationDrawer:DrawerSettings.DrawerContentView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
</navigationDrawer:SfNavigationDrawer>
```
 
```
private void OnPrimaryDrawerToggled(object sender, EventArgs e)
{
    navigationDrawer.ToggleDrawer();
}

private void OnSecondaryDrawerToggled(object sender, EventArgs e)
{
    navigationDrawer.ToggleSecondaryDrawer();
}
```

**Output**
 
 ![multidrawer-kb3.gif](https://support.syncfusion.com/kb/agent/attachment/article/22299/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjU2NjgwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.3pj2t500ZHQvNmGsbG-jdojlh8h-3EGDiYvtHYLutN0)