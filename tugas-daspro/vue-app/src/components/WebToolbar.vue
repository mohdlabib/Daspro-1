<template>
    <v-toolbar color="green darken-4" dark elevation="3">
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
        <div class="hidden-sm-and-down">
            <router-link class="n-under" to="/">
                <v-btn class="light">Home</v-btn>
            </router-link>
            <v-btn class="light">Profile</v-btn>
            <v-btn class="light">Unit/Lembaga</v-btn>
            <v-btn class="light">Akademik</v-btn>
            <v-btn class="light">Dokumen</v-btn>
            <v-btn class="light">Gallery</v-btn>
            <v-btn class="light">Peta</v-btn>
            <v-btn class="light">Vide Profil</v-btn>
            <router-link class="n-under" to="/contact">
                <v-btn class="light">Kontak</v-btn>
            </router-link>
        </div>

        <div class="hidden-sm-and-down">
            <v-navigation-drawer v-model="drawer" class="sidenav" height="800" absolute temporary bottom>
                <v-list class="pa-1">
                    <v-list-tile avatar>
                        <v-list-tile-avatar>
                            <img class="profile" src="https://randomuser.me/api/portraits/men/85.jpg">
                        </v-list-tile-avatar>

                        <v-list-tile-content class="text-profile">
                            <v-list-tile-title>John Leider</v-list-tile-title>
                        </v-list-tile-content>
                    </v-list-tile>
                </v-list>

                <v-list class="pt-4" dense>
                    <v-divider></v-divider>
                    <v-list-tile class="menu-sidenav" v-for="item in items" :key="item.title">
                        <div class="link-profile">
                            <v-list-tile-action>
                                <v-icon>{{ item.icon }} </v-icon>
                            </v-list-tile-action>

                            <v-list-tile-content>
                                <v-list-tile-title> {{ item.title }}</v-list-tile-title>
                            </v-list-tile-content>
                        </div>
                        <v-divider></v-divider>

                    </v-list-tile>
                </v-list>
            </v-navigation-drawer>
        </div>

    </v-toolbar>
</template>

<script>
    export default {
        data() {
            return {
                drawer: false,
                items: [{
                        title: 'Home',
                        icon: 'mdi-home'
                    },
                    {
                        title: 'About',
                        icon: 'mdi-help-box'
                    }
                ]
            }
        }
    }
</script>

<style>
    .profile {
        border-radius: 13px;
        display: block;
        margin-left: auto;
        margin-right: auto;
        margin-top: 20px;
        width: 130px;
        height: 130px;
    }

    .text-profile {
        display: block;
        margin-top: 10px;
        text-align: center;
        font-weight: bolder;
    }

    .menu-sidenav {
        display: block;
    }

    .sidenav {
        background-color: rgb(71, 129, 60) !important;
        opacity: 0.9;
    }

    .link-profile {
        cursor: pointer;
        margin: 16px 20px;

    }
</style>