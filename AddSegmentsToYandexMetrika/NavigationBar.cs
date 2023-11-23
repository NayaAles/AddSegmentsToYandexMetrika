
namespace AddSegmentsToYandexMetrika
{
    public static class NavigationBar
    {
        public const string SelectCounter = "body > div.b-page__content > div.b-page__content-wrap >" +
            " div > div > table > tbody > tr:nth-child(2) > td.counters-list-table-item__cell-type-co" +
            "unter.counters-list-table-item__cell > div > div > a";

        public const string SelectVisitorsAndClients = "body > div.b-page__content > div > div.main-" +
            "menu.main-menu_view_basic.i-bem.main-menu_js_inited > div.main-menu__items-wrap > div > " +
            "div.main-menu__item.main-menu__item_type_visitors.main-menu__item_visible_yes.main-menu_" +
            "_item_multiline_yes > a";

        public const string SelectClients = "#cdp-tabs-tab-1 > span > div > div.visitors-contacts-ta" +
            "b__title";

        public const string SelectEvents = "body > div.b-page__content > div > div.b-page__content-w" +
            "rap > div.b-content > div > div.report-page.report-page_hasCdpFeature.report-page_type_c" +
            "dp.report-page_has-features_yes.i-report-page__content.report-page__redraw-content.repor" +
            "t-page__redraw-content.i-bem.report-page_js_inited > div > div.report-page__tabs > div.r" +
            "eport-page__head > div.report-page__segments-toolbar > div > div.segments-list__segments" +
            " > div > div:nth-child(3) > div.add-filter-button.add-filter-button_segment_primary.add-" +
            "filter-button_report_cdp.segments-list__add-button.i-bem.add-filter-button_js_inited > d" +
            "iv > div > button";

        public const string SelectOrders = "body > div.popup2.popup2_view_classic.popup2_theme_norma" +
            "l.popup2_autoclosable_yes.popup2_target_anchor.popup2_size_s.popup2_search_yes.popup2_ad" +
            "aptive_yes.popup2_hiding_yes.i-bem.popup2_js_inited.popup2_direction_bottom-center.popup" +
            "2_visible_yes > div.dropdown2-lazy__popup-content > div > div.add-filter-button__menu-it" +
            "ems > div > div.segments-menu__menu.segments-menu__menu_type_common.segments-menu__menu_" +
            "segment_primary.segments-menu__menu_js_inited > div.segments-menu__group.segments-menu__" +
            "group_expanded_no.segments-menu__group_disabled_no.segments-menu__group_active_no.order_" +
            "fields > div.segments-menu__group-header.segments-menu__level-0.selection-disabler > div" +
            " > div";

        public const string SelectOrderStatus = "body > div.popup2.popup2_view_classic.popup2_theme_n" +
            "ormal.popup2_autoclosable_yes.popup2_target_anchor.popup2_size_s.popup2_search_yes.popup" +
            "2_adaptive_yes.popup2_hiding_yes.i-bem.popup2_js_inited.popup2_direction_bottom-center.p" +
            "opup2_visible_yes > div.dropdown2-lazy__popup-content > div > div.add-filter-button__men" +
            "u-items > div > div.segments-menu__menu.segments-menu__menu_type_common.segments-menu__m" +
            "enu_segment_primary.segments-menu__menu_js_inited > div.segments-menu__group.segments-me" +
            "nu__group_expanded_yes.segments-menu__group_disabled_no.segments-menu__group_active_no.o" +
            "rder_fields > div.segments-menu__group-content > div.segments-menu__item.segments-menu__" +
            "item_id_cdp-o-orderStatus-list.segments-menu__item_disabled_no.segments-menu__level-1.or" +
            "derStatus > div > span > span";

        public const string SelectInputEmail = "#passp-field-login";

        public const string SelectInputPsw = "#passp-field-passwd";

        public const string SelectLogIn = "#passp\\:sign-in";

        public const string SelectListOrderStatuses = @"//input[@class='checkbox__control']";

        public const string SelectApply = "body > div.popup2.popup2_id_segments-menu-common.popup2_the" +
            "me_normal.popup2_hiding_yes.popup2_target_anchor.popup2_motionless_yes.popup2_autoclosabl" +
            "e_yes.popup2_adaptive_yes.popup2_view_classic.segment-panel-popup.i-bem.popup2_js_inited." +
            "segment-panel-popup_js_inited.popup2_direction_right-bottom.popup2_visible_yes > div.popu" +
            "p2__content > div > div.segment-panel__footer > button";

        public const string SelectApplyXPath = @"//button[@class='button button_theme_action button_si" +
            "ze_s segment-panel__confirm i-bem button_js_inited']";
        
        public const string SelectPreSaveSegment = "body > div.b-page__content > div > div.b-page__con" +
            "tent-wrap > div.b-content > div > div.report-page.report-page_hasCdpFeature.report-page_t" +
            "ype_cdp.report-page_has-features_yes.i-report-page__content.report-page__redraw-content.r" +
            "eport-page__redraw-content.i-bem.report-page_js_inited > div > div.report-page__tabs > di" +
            "v.report-page__head > div.segments-selector.segments-selector_editable_yes.segments-selec" +
            "tor_action_yes.segments-selector_report_cdp.report-page__segments-selector.i-bem.segments" +
            "-selector_js_inited.segments-selector_clear_no.segments-selector_empty_no.segments-select" +
            "or_state_new > div > div > div > button.button2.button2_theme_raised.button2_view_default" +
            ".button2_size_s.segments-selector__save-as-action.i-bem.button2_js_inited";

        public const string SelectClearInput = "body > div.modal.modal_theme_normal.modal_autoclosable" +
            "_yes.modal_has-close.modal_animate_no.popup2.popup2_autoclosable_yes.segments-selector__e" +
            "dit-popup.i-bem.popup2_js_inited.modal_js_inited.modal_has-animation_yes.popup2_visible_y" +
            "es.modal_visible_yes > div > div > div > div.modal__modal-content > div > div.segments-se" +
            "lector__popup-inner-content > span > span > span";

        public const string SelectInputSegmentName = "body > div.modal.modal_theme_normal.modal_autocl" +
            "osable_yes.modal_has-close.modal_animate_no.popup2.popup2_autoclosable_yes.segments-selec" +
            "tor__edit-popup.i-bem.popup2_js_inited.modal_js_inited.popup2_visible_yes.modal_has-anima" +
            "tion_yes.modal_visible_yes > div > div > div > div.modal__modal-content > div > div.segme" +
            "nts-selector__popup-inner-content > span";

        public const string SelectSave = "body > div.modal.modal_theme_normal.modal_autoclosable_yes.m" +
            "odal_has-close.modal_animate_no.popup2.popup2_autoclosable_yes.segments-selector__edit-po" +
            "pup.i-bem.popup2_js_inited.modal_js_inited.popup2_visible_yes.modal_has-animation_yes.mod" +
            "al_visible_yes > div > div > div > div.modal__modal-content > div > div.segments-selector" +
            "__controls > button.button.button_size_s.button_theme_action.button_action_save.segments-" +
            "selector__save.i-bem.button_js_inited";

        public const string SelectMoreNext20 = "body > div.popup2.popup2_id_segments-menu-common.popup" +
            "2_theme_normal.popup2_hiding_yes.popup2_target_anchor.popup2_motionless_yes.popup2_autocl" +
            "osable_yes.popup2_adaptive_yes.popup2_view_classic.segment-panel-popup.i-bem.popup2_js_in" +
            "ited.segment-panel-popup_js_inited.popup2_direction_right-center.popup2_visible_yes > div" +
            ".popup2__content > div > div.segment-panel__content-wrap.wheel-prevent.i-bem.wheel-preven" +
            "t_js_inited > div > div > div > button";

        public const string SelectCross = "body > div.b-page__content > div > div.b-page__content-wrap" +
            " > div.b-content > div > div.report-page.report-page_hasCdpFeature.report-page_type_cdp.r" +
            "eport-page_has-features_yes.i-report-page__content.report-page__redraw-content.report-pag" +
            "e__redraw-content.i-bem.report-page_js_inited > div > div.report-page__tabs > div.report-" +
            "page__head > div.report-page__segments-toolbar > div > div.segments-list__segments > div " +
            "> div.segments-list__group.segments-list__group_filled_yes.segments-list__group_few_yes >" +
            " div.segments-list__item-wrapper.segments-list__item-wrapper_idx_0 > div > span";

        public const string SelectInputXPath = @"//input[@value='Новый сегмент']";
    }
}
