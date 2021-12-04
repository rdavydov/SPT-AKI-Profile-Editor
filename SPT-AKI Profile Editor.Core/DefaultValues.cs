﻿using System.Collections.Generic;

namespace SPT_AKI_Profile_Editor.Core
{
    public static class DefaultValues
    {
        public const string ColorScheme = "Light.Emerald";
        public const string PocketsContainerTpl = "557596e64bdc2dc2118b4571";
        public const string PocketsSlotId = "Pockets";
        public const string MoneysDollarsTpl = "5696686a4bdc2da3298b456a";
        public const string MoneysRublesTpl = "5449016a4bdc2d6f028b456f";
        public const string MoneysEurosTpl = "569668774bdc2da2298b4568";
        public const float CommonSkillMaxValue = 5100;
        public static List<string> BannedItems => new()
        {
            "543be5dd4bdc2deb348b4569",
            "55d720f24bdc2d88028b456d",
            "557596e64bdc2dc2118b4571",
            "566965d44bdc2d814c8b4571",
            "566abbb64bdc2d144c8b457d",
            "5448f39d4bdc2d0a728b4568",
            "5943d9c186f7745a13413ac9",
            "5996f6cb86f774678763a6ca",
            "5996f6d686f77467977ba6cc",
            "5996f6fc86f7745e585b4de3",
            "5cdeb229d7f00c000e7ce174",
            "5d52cc5ba4b9367408500062"
        };
        public static Dictionary<string, string> DefaultDirsList => new()
        {
            ["dir_globals"] = "Aki_Data\\Server\\database\\locales\\global",
            ["dir_traders"] = "Aki_Data\\Server\\database\\traders",
            ["dir_bots"] = "Aki_Data\\Server\\database\\bots\\types",
            ["dir_profiles"] = "user\\profiles"
        };
        public static Dictionary<string, string> DefaultFilesList => new()
        {
            ["file_globals"] = "Aki_Data\\Server\\database\\globals.json",
            ["file_items"] = "Aki_Data\\Server\\database\\templates\\items.json",
            ["file_quests"] = "Aki_Data\\Server\\database\\templates\\quests.json",
            ["file_areas"] = "Aki_Data\\Server\\database\\hideout\\areas.json",
            ["file_serverexe"] = "Server.exe"
        };
        public static List<AppLocalization> DefaultLocalizations => new()
        {
            new AppLocalization { Key = "en", Name = "English", Translations = new Dictionary<string, string>() {
                ["button_yes"] = "Yes",
                ["button_no"] = "No",
                ["button_close"] = "Close",
                ["button_select"] = "Select",
                ["button_settings"] = "SETTINGS",
                ["button_save_profile"] = "SAVE PROFILE",
                ["button_reload_profile"] = "RESET CHANGES",
                ["progress_dialog_title"] = "Please wait ...",
                ["progress_dialog_caption"] = "Loading data",
                ["reload_profile_dialog_title"] = "Resetting changes",
                ["reload_profile_dialog_caption"] = "Are you sure? All changes will be lost",
                ["server_select"] = "Select the SPT-AKI Server directory.",
                ["invalid_server_location_caption"] = "Error",
                ["invalid_server_location_text"] = "The selected path does not seem to be a SPT-AKI server location.",
                ["no_accounts"] = "Failed to get accounts. No accounts?!",
                ["tab_server_location_select"] = "Select",
                ["tab_info_title"] = "Information",
                ["tab_info_pmc"] = "PMC",
                ["tab_info_scav"] = "Scav",
                ["tab_info_id"] = "ID",
                ["tab_info_nickname"] = "Nickname",
                ["tab_info_side"] = "Side",
                ["tab_info_voice"] = "Voice",
                ["tab_info_level"] = "Level",
                ["tab_info_experience"] = "Experience",
                ["tab_info_game_version"] = "Game Version",
                ["tab_info_pockets"] = "Pockets",
                ["tab_info_head"] = "Head",
                ["tab_merchants_title"] = "Merchants",
                ["tab_merchants_name"] = "Name",
                ["tab_merchants_level"] = "Level",
                ["tab_merchants_enabled"] = "Enabled",
                ["tab_merchants_sales_sum"] = "Sales sum",
                ["tab_merchants_standing"] = "Standing",
                ["tab_quests_title"] = "Quests",
                ["tab_quests_trader"] = "Trader",
                ["tab_quests_name"] = "Name",
                ["tab_quests_status"] = "Status",
                ["tab_quests_edit_all_button"] = "Execute",
                ["tab_quests_mark_all"] = "Mark all quests:",
                ["tab_no_data"] = "No data to display.\nTry to enable adding missing items in settings",
                ["tab_settings_title"] = "Settings",
                ["tab_settings_lang"] = "Language",
                ["tab_settings_server"] = "SPT-AKI Server directory",
                ["tab_settings_account"] = "Account",
                ["tab_settings_color_scheme"] = "Color scheme",
                ["tab_settings_auto_add_quests"] = "Adding missing quests to the profile",
                ["tab_settings_auto_add_masterings"] = "Adding missing weapon masterings to profile",
                ["tab_settings_auto_add_scav_skills"] = "Adding missing Scav skills to the profile",
                ["tab_settings_main"] = "Main",
                ["tab_settings_additional"] = "Additional",
                ["tab_hideout_title"] = "Hideout",
                ["tab_hideout_area"] = "Area",
                ["tab_hideout_level"] = "Level",
                ["tab_hideout_maximum_button"] = "Set everything to maximum",
                ["tab_skills_title"] = "Skills",
                ["tab_skills_skill"] = "Skill",
                ["tab_skills_exp"] = "Experience",
                ["tab_skills_set_all"] = "Set experience for all skills:",
                ["tab_mastering_title"] = "Weapon mastering",
                ["tab_mastering_weapon"] = "Weapon",
                ["tab_mastering_exp"] = "Experience",
                ["tab_mastering_set_all"] = "Set experience for all weapons:",
                ["tab_mastering_no_data"] = "No data to display. Play at least one match",
                ["tab_examined_items_title"] = "Examined items",
                ["tab_examined_items_item"] = "Item",
                ["tab_examined_items_examine_all_button"] = "Examine all",
                ["tab_stash_title"] = "Stash",
                ["tab_stash_money"] = "Money",
                ["tab_stash_items"] = "Items",
                ["tab_stash_dialog_money"] = "Enter the amount of money you want to add",
                ["tab_stash_no_slots"] = "Not enough free slots",
                ["tab_stash_category"] = "Category",
                ["tab_stash_amount"] = "Amount",
                ["tab_stash_add"] = "Add",
                ["tab_stash_remove"] = "Remove all",
                ["tab_stash_fir"] = "Item found in raid",
                ["tab_stash_search"] = "Search",
                ["tab_stash_items_adding"] = "Adding items",
                ["tab_backups_title"] = "Backups",
                ["tab_backups_date"] = "Date",
                ["tab_backups_actions"] = "Actions",
                ["tab_backups_restore"] = "Restore",
                ["tab_backups_remove"] = "Remove",
                ["tab_about_title"] = "About",
                ["tab_about_text"] = "Program for editing player profile on the SPT-AKI server",
                ["tab_about_developer"] = "Developer:",
                ["tab_about_latest_version"] = "Latest version:",
                ["tab_about_support"] = "Support the developer:",
                ["save_profile_dialog_title"] = "Saving a profile",
                ["save_profile_dialog_caption"] = "Profile saved successfully",
                ["save_profile_dialog_ok"] = "OK",
                ["remove_backup_dialog_title"] = "Deleting a backup",
                ["remove_backup_dialog_caption"] = "Are you sure want to delete this backup?",
                ["restore_backup_dialog_title"] = "Restoring a backup",
                ["restore_backup_dialog_caption"] = "Are you sure want to restore this backup?",
                ["remove_stash_item_title"] = "Removing an item",
                ["remove_stash_item_caption"] = "Are you sure you want to delete this item?",
                ["remove_stash_items_caption"] = "Are you sure you want to delete all items?",
                ["tab_stash_warning_title"] = "The stash edit function can damage the profile. Use at your own risk.",
                ["tab_stash_mod_items"] = "The stash contains items added by mods.\nFunctions for adding money and items are disabled.\nTo use them, remove these items, or move them to the container.",
                ["tab_stash_warning_button"] = "I understood",
                ["profile_empty"] = "There is no data to display. The profile is empty. Log into the game under this profile and try again.",
                ["app_quit"] = "Quit application?",
                ["button_quit"] = "Quit",
                ["button_cancel"] = "Cancel",
                ["tab_clothing_title"] = "Clothing",
                ["tab_clothing_acquired"] = "Acquired",
                ["tab_clothing_acquire_all"]= "Acquire all",
                ["server_runned"] = "The server you selected is currently running. Shut down the server and restart the program.",
                ["update_avialable"] = "Update available",
                ["update_caption"] = "A new version of the program is available. Open the download page?",
                ["tab_presets_title"] = "Presets",
                ["tab_presets_export"] = "Export",
                ["tab_presets_import"] = "Import",
                ["tab_presets_wrong_file"] = "This file does not contain the weapon build",
                ["remove_preset_dialog_title"] = "Deleting a preset",
                ["remove_preset_dialog_caption"] = "Are you sure want to delete this preset?",
                ["tab_presets_export_all"] = "Export all",
                ["remove_presets_dialog_caption"] = "Are you sure want to delete all presets?",
                ["tab_presets_ergonomics"] = "Ergonomics",
                ["tab_preset_recoil_up"] = "Recoil Up",
                ["tab_preset_recoil_back"] = "Recoil Back",
                ["message_duplicated_items"] = "The profile contains items with the same ID. Do you want to fix it? The profile will be automatically saved with the creation of a backup."
            } },
            new AppLocalization { Key = "ru", Name = "Русский", Translations = new Dictionary<string, string>() {
                ["button_yes"] = "Да",
                ["button_no"] = "Нет",
                ["button_close"] = "Закрыть",
                ["button_select"] = "Выбрать",
                ["button_settings"] = "НАСТРОЙКИ",
                ["button_save_profile"] = "СОХРАНИТЬ ПРОФИЛЬ",
                ["button_reload_profile"] = "СБРОСИТЬ ИЗМЕНЕНИЯ",
                ["progress_dialog_title"] = "Пожалуйста подождите ...",
                ["progress_dialog_caption"] = "Идет загрузка данных",
                ["reload_profile_dialog_title"] = "Сброс изменений",
                ["reload_profile_dialog_caption"] = "Вы уверены? Все изменения будут потеряны",
                ["server_select"] = "Выберите папку с сервером SPT-AKI.",
                ["invalid_server_location_caption"] = "Ошибка",
                ["invalid_server_location_text"] = "Сервер SPT-AKI не найден. Попробовать снова?",
                ["no_accounts"] = "Не удалось получить аккаунты. Нет аккаунтов?!",
                ["tab_server_location_select"] = "Выбрать",
                ["tab_info_title"] = "Информация",
                ["tab_info_pmc"] = "ЧВК",
                ["tab_info_scav"] = "Дикий",
                ["tab_info_id"] = "ID",
                ["tab_info_nickname"] = "Никнейм",
                ["tab_info_side"] = "Сторона",
                ["tab_info_voice"] = "Голос",
                ["tab_info_level"] = "Уровень",
                ["tab_info_experience"] = "Опыт",
                ["tab_info_game_version"] = "Версия игры",
                ["tab_info_pockets"] = "Карманы",
                ["tab_info_head"] = "Голова",
                ["tab_merchants_title"] = "Торговцы",
                ["tab_merchants_name"] = "Имя",
                ["tab_merchants_level"] = "Уровень",
                ["tab_merchants_enabled"] = "Включен",
                ["tab_merchants_sales_sum"] = "Сумма оборота",
                ["tab_merchants_standing"] = "Отношение",
                ["tab_quests_title"] = "Квесты",
                ["tab_quests_trader"] = "Торговец",
                ["tab_quests_name"] = "Название",
                ["tab_quests_status"] = "Статус",
                ["tab_quests_edit_all_button"] = "Выполнить",
                ["tab_quests_mark_all"] = "Отметить все квесты:",
                ["tab_no_data"] = "Нет данных для отображения.\nПопробуйте включить добавление отсутствующих элементов в настройках",
                ["tab_settings_title"] = "Настройки",
                ["tab_settings_lang"] = "Язык",
                ["tab_settings_server"] = "Каталог SPT-AKI Server",
                ["tab_settings_account"] = "Аккаунт",
                ["tab_settings_color_scheme"] = "Цветовая схема",
                ["tab_settings_auto_add_quests"] = "Добавление отсутствующих квестов в профиль",
                ["tab_settings_auto_add_masterings"] = "Добавление отсутствующих навыков владения оружием в профиль",
                ["tab_settings_auto_add_scav_skills"] = "Добавление отсутствующих умений Дикого в профиль",
                ["tab_settings_main"] = "Основное",
                ["tab_settings_additional"] = "Дополнительное",
                ["tab_hideout_title"] = "Убежище",
                ["tab_hideout_area"] = "Зона",
                ["tab_hideout_level"] = "Уровень",
                ["tab_hideout_maximum_button"] = "Установить все на максимум",
                ["tab_skills_title"] = "Умения",
                ["tab_skills_skill"] = "Умение",
                ["tab_skills_exp"] = "Опыт",
                ["tab_skills_set_all"] = "Установить опыт для всех умений:",
                ["tab_mastering_title"] = "Владение оружием",
                ["tab_mastering_weapon"] = "Оружие",
                ["tab_mastering_exp"] = "Опыт",
                ["tab_mastering_set_all"] = "Установить опыт для всего оружия:",
                ["tab_mastering_no_data"] = "Нет данных. Сыграйте хотя бы один матч",
                ["tab_examined_items_title"] = "Изученные предметы",
                ["tab_examined_items_item"] = "Предмет",
                ["tab_examined_items_examine_all_button"] = "Изучить все",
                ["tab_stash_title"] = "Схрон",
                ["tab_stash_items"] = "Предметы",
                ["tab_stash_money"] = "Деньги",
                ["tab_stash_dialog_money"] = "Введите сумму денег, которую хотите добавить",
                ["tab_stash_no_slots"] = "Недостаточно свободных слотов",
                ["tab_stash_category"] = "Категория",
                ["tab_stash_amount"] = "Количество",
                ["tab_stash_add"] = "Добавить",
                ["tab_stash_remove"] = "Удалить все",
                ["tab_stash_fir"] = "Предмет найденный в рейде",
                ["tab_stash_search"] = "Поиск",
                ["tab_stash_items_adding"] = "Добавление предметов",
                ["tab_backups_title"] = "Бэкапы",
                ["tab_backups_date"] = "Дата",
                ["tab_backups_actions"] = "Действия",
                ["tab_backups_restore"] = "Восстановить",
                ["tab_backups_remove"] = "Удалить",
                ["tab_about_title"] = "О программе",
                ["tab_about_text"] = "Программа для редактирования профиля игрока на сервере SPT-AKI",
                ["tab_about_developer"] = "Разработчик:",
                ["tab_about_latest_version"] = "Последняя версия:",
                ["tab_about_support"] = "Поддержать разработчика:",
                ["save_profile_dialog_title"] = "Сохранение профиля",
                ["save_profile_dialog_caption"] = "Профиль успешно сохранен",
                ["save_profile_dialog_ok"] = "OK",
                ["remove_backup_dialog_title"] = "Удаление бэкапа",
                ["remove_backup_dialog_caption"] = "Вы действительно хотите удалить этот бэкап?",
                ["restore_backup_dialog_title"] = "Восстановление бэкапа",
                ["restore_backup_dialog_caption"] = "Вы действительно хотите восстановить этот бэкап?",
                ["remove_stash_item_title"] = "Удаление предмета",
                ["remove_stash_item_caption"] = "Вы действительно хотите удалить этот предмет?",
                ["remove_stash_items_caption"] = "Вы действительно хотите удалить все предметы?",
                ["tab_stash_warning_title"] = "Функция редактирования схрона может повредить профиль. Используйте на свой страх и риск.",
                ["tab_stash_mod_items"] = "Схрон содержит предметы добавленные модами.\nФункции добавления денег и предметов отключены.\nЧто бы воспользоваться ими удалите эти предметы, или переместите их в контейнер.",
                ["tab_stash_warning_button"] = "Я понял",
                ["profile_empty"] = "Нет данных для отображения. Профиль пустой. Зайдите в игру под этим профилем и попробуйте снова.",
                ["app_quit"] = "Выйти из приложения?",
                ["button_quit"] = "Выход",
                ["button_cancel"] = "Отмена",
                ["tab_clothing_title"] = "Одежда",
                ["tab_clothing_acquired"] = "Приобретено",
                ["tab_clothing_acquire_all"] = "Получить все",
                ["server_runned"] = "Выбранный вами сервер запущен в данный момент. Выключите сервер и перезапустите программу.",
                ["update_avialable"] = "Доступно обновление",
                ["update_caption"] = "Доступна новая версия программы. Открыть страницу загрузки?",
                ["tab_presets_title"] = "Сборки",
                ["tab_presets_export"] = "Экспорт",
                ["tab_presets_import"] = "Импорт",
                ["tab_presets_wrong_file"] = "Этот файл не содержит сборку оружия",
                ["remove_preset_dialog_title"] = "Удаление сборки",
                ["remove_preset_dialog_caption"] = "Вы действительно хотите удалить эту сборку?",
                ["tab_presets_export_all"] = "Экспортировать все",
                ["remove_presets_dialog_caption"] = "Вы действительно хотите удалить все сборки?",
                ["tab_presets_ergonomics"] = "Эргономика",
                ["tab_preset_recoil_up"] = "Вертикальная отдача",
                ["tab_preset_recoil_back"] = "Горизонтальная отдача",
                ["message_duplicated_items"] = "В профиле есть предметы с одинаковыми ID. Вы хотите это исправить? Профиль будет автоматически сохранен с созданием бэкапа."
            } }
        };
    }
}