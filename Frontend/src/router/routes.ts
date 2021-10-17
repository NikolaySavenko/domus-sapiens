import { RouteRecordRaw } from 'vue-router';

const routes: RouteRecordRaw[] = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [{ path: '', component: () => import('src/pages/main.vue') },
    { path: 'profile', component: () => import('pages/profile.vue') },
    { path: 'information', component: () => import('src/pages/information.vue') },
    { path: 'mydevice', component: () => import('src/pages/mydevice.vue') },
    { path: 'myrooms', component: () => import('src/pages/myrooms.vue') },
    { path: 'settings', component: () => import('src/pages/settings.vue') },],
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/Error404.vue'),
  },
];

export default routes;
