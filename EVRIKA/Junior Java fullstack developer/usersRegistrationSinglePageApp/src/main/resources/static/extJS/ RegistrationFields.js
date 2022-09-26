Ext.onReady(function(){
    var formPanel = Ext.create('Ext.Panel', {
                    title: 'Регистрация пользователя',
                    width: 250,
                    autoHeight: true,
                    bodyPadding: 10,
                    defaults: {
                        labelWidth: 100
                    },
                    items: [{
                        xtype: 'textfield',
                        fieldLabel: 'Введите имя:',
                        allowBlank:false,
                        emptyText: 'Укажите ваше имя', //подсказка в текстовом поле
                        minLength: 3,
                        maxLength: 15,
                        name: 'name'
                    },
                    {
                        xtype: 'textfield',
                        fieldLabel: 'Введите фамилию:',
                        allowBlank:false,
                        emptyText: 'Укажите вашу фамилию', //подсказка в текстовом поле
                        minLength: 3,
                        maxLength: 15,
                        name: 'surname'
                    }],
                    renderTo: Ext.getBody()
        });
});